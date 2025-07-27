using Data;
using LinqToDB;
using Logica.DTOs;
using Logica.Helpers;
using Logica.Library;
using Logica.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LLibroAutor : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idLibroAutor = 0;

        public int idLibroAutor
        {
            get => _idLibroAutor;
            set => _idLibroAutor = value;
        }

        public LLibroAutor() { }
        
        public LLibroAutor(object[] obj)
        {
            _dataGridView = (DataGridView)obj[0];
        }

        public async Task<List<LibroAutorDTO>> GetLibrosAutoresAsync(Conexion db)
        {
            var rawData = await (from la in db.GetTable<LibroAutor>()
                                 orderby la.idLIBROAUTOR
                                 join l in db.GetTable<Libro>()
                                    on la.LIBRO_idLIBRO equals l.idLIBRO
                                 join a in db.GetTable<Autor>()
                                    on la.AUTOR_idAUTOR equals a.idAUTOR
                                 select new
                                 {
                                     la.idLIBROAUTOR,
                                     l = l.titulo,
                                     a = a.nombre

                                 })
                                 .ToListAsync();

            var result = rawData 
                         .GroupBy(x => new
                         {
                             x.idLIBROAUTOR,
                             x.l,
                             x.a
                         })
                         .Select(group => new LibroAutorDTO
                         {
                             ID = group.Key.idLIBROAUTOR,
                             Libro = group.Key.l,
                             Autor = group.Key.a
                         })
                         .ToList();
            return result;                         
        }

        public async Task ListLibroAutorAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await GetLibrosAutoresAsync(db);
                    
                    _dataGridView.DataSource = list;
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);                    
                    DataGridViewHelper.SetupDataGridViewDefaults(_dataGridView);                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar asociación Libro - Autor: " + ex.Message);
            }
        }

        public async Task SearchLibroAutorAsync(string field)
        {
            try
            {
                using (var db = new Conexion())
                {
                    var librosAutores = await GetLibrosAutoresAsync(db);

                    if (!string.IsNullOrWhiteSpace(field))
                    {
                        var lowerField = field.ToLower();
                        librosAutores = librosAutores
                                        .Where(la =>
                                            la.ID.ToString().Contains(lowerField) ||
                                            la.Libro != null && la.Libro.ToLower().Contains(lowerField) ||
                                            la.Autor != null && la.Autor.ToLower().Contains(lowerField))
                                        .ToList();
                    }

                    _dataGridView.DataSource = librosAutores;
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                    DataGridViewHelper.SetupDataGridViewDefaults(_dataGridView);
                }
            }
            catch
            {
                MessageBox.Show("Error al buscar asociación Libro - Autor.");
            }
        }

        public async Task SaveLibroAutor(LibroAutorInputModel input)
        {
            using (var db = new Conexion())
            {
                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<LibroAutor>()
                                    .Value(la => la.LIBRO_idLIBRO, input.Libro)
                                    .Value(la => la.AUTOR_idAUTOR, input.Autor)
                                    .InsertAsync();
                            break;

                        case "update":
                            await db.GetTable<LibroAutor>()
                                    .Where(la => la.idLIBROAUTOR == _idLibroAutor)
                                    .Set(la => la.LIBRO_idLIBRO, input.Libro)
                                    .Set(la => la.AUTOR_idAUTOR, input.Autor)
                                    .UpdateAsync();
                            break;
                    }

                    await db.CommitTransactionAsync();
                    MessageBox.Show("Asociación Libro - Autor guardada exitosamente.");
                }
                catch (Exception ex)
                {
                    await db.RollbackTransactionAsync();
                    MessageBox.Show("Error al guardar asociación Libro - Autor: " + ex.Message);
                }
            }

        }

        public async Task DeleteLibroAutorAsync()
        {
            GetLibroAutorSelected();

            if (_idLibroAutor.Equals(0))
            {
                MessageBox.Show("Selecciona un Libro - Autor!");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar asociación Libro - Autor?",
                    "Eliiminar asociación Libro - Autor",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _LibroAutor
                                .Where(la => la.idLIBROAUTOR.Equals(_idLibroAutor))
                                .DeleteAsync();
                    }
                }

                await ListLibroAutorAsync();
            }
        }

        public LibroAutor GetLibroAutor(int idLibroAutor)
        {
            using (var db = new Conexion())
            {
                return db._LibroAutor.FirstOrDefault(la => la.idLIBROAUTOR == idLibroAutor);
            }
        }      

        public void GetLibroAutorSelected()
        {
            if (_dataGridView.CurrentRow != null)
            {
                _idLibroAutor = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idLibroAutor = 0;
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }
    }
}
