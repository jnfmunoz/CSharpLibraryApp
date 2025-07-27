using Logica.Library;
using Logica.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Data;
using LinqToDB;
using Logica.Helpers;
using Logica.ViewModels;

namespace Logica
{
    public class LAutor : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idAutor = 0;

        public int idAutor
        {
            get => _idAutor;
            set => _idAutor = value;
        }

        public LAutor() { }

        public LAutor(object[] obj)
        {
            _dataGridView = (DataGridView)obj[0];
        }

        private async Task<List<AutorDTO>> GetAutoresAsync(Conexion db)
        {
            var rawData = await (from a in db.GetTable<Autor>()
                                 join p in db.GetTable<Pais>()
                                    on a.PAIS_idPAIS equals p.idPAIS
                                 orderby a.idAUTOR
                                 select new
                                 {
                                     a.idAUTOR,
                                     a.nombre,
                                     a.fecha_nacimiento,
                                     pais = p.nombre
                                 }).
                                 ToListAsync();

            var result = rawData
                         .GroupBy(x => new
                         {
                             x.idAUTOR,
                             x.nombre,
                             x.fecha_nacimiento,
                             x.pais
                         })
                         .Select(group => new AutorDTO
                         {
                             ID = group.Key.idAUTOR,
                             Nombre = group.Key.nombre,
                             FechaNacimiento = group.Key.fecha_nacimiento,
                             Pais = string.Join(", ", group.Select(p => p.pais).Distinct())
                         })
                         .ToList();

            return result;
        }

        public async Task ListAutorAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await GetAutoresAsync(db);

                    _dataGridView.DataSource = list;
                    DataGridViewHelper.RenameHeaderTextPais(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar autores: " + ex.Message);
            }
        }

        public async Task SearchAutorAsync(string field)
        {
            try
            {
                using (var db = new Conexion())
                {
                    var autores = await GetAutoresAsync(db);

                    if (!string.IsNullOrWhiteSpace(field))
                    {
                        autores = autores
                                  .Where(a =>
                                     a.ID.ToString().Contains(field) ||
                                     (a.Nombre != null && a.Nombre.ToLower().Contains(field)) ||
                                     (a.Pais != null && a.Pais.ToLower().Contains(field)) ||
                                     a.FechaNacimiento.ToString("dd/MM/yyyy").ToLower().Contains(field) || // búsqueda por fecha
                                     a.FechaNacimiento.ToString("yyyy-MM-dd").ToLower().Contains(field))
                                  .ToList();
                    }

                    _dataGridView.DataSource = autores;
                    DataGridViewHelper.RenameHeaderTextPais(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar autor: " + ex.Message);
            }
        }

        public async Task SaveAutorAsync(AutorInputModel input)
        {
            using (var db = new Conexion())
            {
                await db.BeginTransactionAsync();
                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Autor>()
                                    .Value(a => a.nombre, input.Nombre)
                                    .Value(a => a.fecha_nacimiento, input.FechaNacimiento)
                                    .Value(a => a.PAIS_idPAIS, input.Pais)
                                    .InsertAsync();
                            break;

                        case "update":
                            await db.GetTable<Autor>()
                                    .Where(a => a.idAUTOR == _idAutor)
                                    .Set(a => a.nombre, input.Nombre)
                                    .Set(a => a.fecha_nacimiento, input.FechaNacimiento)
                                    .Set(a => a.PAIS_idPAIS, input.Pais)
                                    .UpdateAsync();
                            break;
                    }

                    await db.CommitTransactionAsync();
                    MessageBox.Show("Autor guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    await db.CommitTransactionAsync();
                    MessageBox.Show("Autor guardado exitosamente.");
                }
            }
        }

        public async Task DeleteAutorAsync()
        {
            GetAutorSelected();

            if (_idAutor.Equals(0))
            {
                MessageBox.Show("Selecciona un autor");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar este autor?",
                    "Eliminar Autor",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Autor
                                .Where(a => a.idAUTOR.Equals(_idAutor))
                                .DeleteAsync();
                    }
                }
                await ListAutorAsync();
            }
        }

        public Autor GetAutor(int idAutor)
        {
            using (var db = new Conexion())
            {
                return db._Autor.FirstOrDefault(a => a.idAUTOR == idAutor);
            }
        }

        public List <Autor> GetAutores()
        {
            using (var db = new Conexion())
            {
                return db.GetTable<Autor>().ToList();
            }
        }

        public void GetAutorSelected()
        {
            if (_dataGridView.CurrentRow != null)
            {
                _idAutor = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idAutor = 0;
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }
    }
}

