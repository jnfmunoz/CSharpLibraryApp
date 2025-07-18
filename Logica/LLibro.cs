using Data;
using LinqToDB;
using LinqToDB.DataProvider.DB2;
using Logica.DTOs;
using Logica.Helpers;
using Logica.Library;
using Logica.ViewModels;
using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class LLibro : Librarys
    {
        private DataGridView _dataGridView;
        private String _action = "insert";
        private int _idLibro = 0;

        public int idLibro
        {
            get => _idLibro;
            set => _idLibro = value;
        }

        public LLibro() { }

        public LLibro(object[] objetos)
        {
            _dataGridView = (DataGridView)objetos[0];
        }

        private async Task<List<LibroDTO>> GetLibrosAsync(Conexion db)
        {
            var rawData = await (from l in db.GetTable<Libro>()
                                 orderby l.idLIBRO
                                 join e in db.GetTable<Editorial>()
                                    on l.EDITORIAL_idEDITORIAL equals e.idEDITORIAL
                                 join g in db.GetTable<Genero>()
                                    on l.GENERO_idGENERO equals g.idGENERO
                                 join la in db.GetTable<LibroAutor>()
                                    on l.idLIBRO equals la.LIBRO_idLIBRO into libroAutor
                                 from la in libroAutor.DefaultIfEmpty()
                                 join a in db.GetTable<Autor>()
                                    on la.AUTOR_idAUTOR equals a.idAUTOR into autor
                                 from a in autor.DefaultIfEmpty()
                                 select new
                                 {
                                     l.idLIBRO,
                                     l.titulo,
                                     l.isbn,
                                     l.anio_publicacion,
                                     l.sinopsis,
                                     e = e.nombre,
                                     g = g.nombre,
                                     a = a.nombre
                                 })
                                 .ToListAsync();

            var result = rawData
                .GroupBy(x => new
                {
                    x.idLIBRO,
                    x.titulo,
                    x.isbn,
                    x.anio_publicacion,
                    x.sinopsis,
                    x.e,
                    x.g,
                    x.a
                })
                .Select(group => new LibroDTO
                {
                    ID = group.Key.idLIBRO,
                    Titulo = group.Key.titulo,
                    ISBN = group.Key.isbn,
                    AnioPublicacion = group.Key.anio_publicacion,
                    Sinopsis = group.Key.sinopsis,
                    Editorial = group.Key.e,
                    Genero = group.Key.g,
                    Autor = string.Join(", ", group.Select(a => a.a).Distinct())
                })
                .ToList();

            return result;
        }

        public async Task ListLibroAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await GetLibrosAsync(db);

                    _dataGridView.DataSource = list;
                   
                    DataGridViewHelper.RenameHeaderTextTitulo(_dataGridView);
                    DataGridViewHelper.RenameHeaderTextAnioPublicacion(_dataGridView);
                    DataGridViewHelper.RenameHeaderTextAnioGenero(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar Libros: " + ex.Message);
            }
        }

        public async Task SearchLibroAsync(string field)
        {
            try
            {
                using (var db = new Conexion())
                {
                    var libros = await GetLibrosAsync(db);

                    if (!string.IsNullOrWhiteSpace(field))
                    {
                            libros = libros
                                .Where(l =>                            
                                       l.ID.ToString().Contains(field) ||
                                       (l.Titulo != null && l.Titulo.ToLower().Contains(field.ToLower())) ||
                                       (l.ISBN != null && l.ISBN.ToLower().Contains(field.ToLower())) ||
                                       l.AnioPublicacion.ToString().Contains(field) ||
                                       (l.Sinopsis != null && l.Sinopsis.ToLower().Contains(field.ToLower())) ||
                                       (l.Editorial != null && l.Editorial.ToLower().Contains(field.ToLower())) ||
                                       (l.Genero != null && l.Genero.ToLower().Contains(field.ToLower())) ||
                                       (l.Autor != null && l.Autor.ToLower().Contains(field.ToLower()))                            )
							    .ToList();                        
                    }

                    _dataGridView.DataSource = libros;

                    DataGridViewHelper.RenameHeaderTextTitulo(_dataGridView);
                    DataGridViewHelper.RenameHeaderTextAnioPublicacion(_dataGridView);
                    DataGridViewHelper.RenameHeaderTextAnioGenero(_dataGridView);
                    DataGridViewHelper.AutoResizeColumns(_dataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libro: " + ex.Message);
            }
        }
       
        public async Task SaveLibroAsync(LibroInputModel input)
        {
            using (var db = new Conexion())
            {
                await db.BeginTransactionAsync();

                try
                {
                    switch (_action)
                    {
                        case "insert":
                            await db.GetTable<Libro>()
                                    .Value(l => l.titulo, input.Titulo)
                                    .Value(l => l.isbn, input.ISBN)
                                    .Value(l => l.anio_publicacion, input.AnioPublicacion)
                                    .Value(l => l.sinopsis, input.Sinopsis)
                                    .Value(l => l.EDITORIAL_idEDITORIAL, input.EDITORIAL_idEDITORIAL)
                                    .Value(l => l.GENERO_idGENERO, input.GENERO_idGENERO)
                                    .InsertAsync();
                            break;

                        case "update":
                            await db.GetTable<Libro>()
                                    .Where(l => l.idLIBRO == _idLibro)
                                    .Set(l => l.titulo, input.Titulo)
                                    .Set(l => l.isbn, input.ISBN)
                                    .Set(l => l.anio_publicacion, input.AnioPublicacion)
                                    .Set(l => l.sinopsis, input.Sinopsis)
                                    .Set(l => l.EDITORIAL_idEDITORIAL, input.EDITORIAL_idEDITORIAL)
                                    .Set(l => l.GENERO_idGENERO, input.GENERO_idGENERO)
                                    .UpdateAsync();
                            break;
                    }

                    await db.CommitTransactionAsync();
                    MessageBox.Show("Libro guardado exitosamente.");
                }
                catch (Exception ex)
                {
                    await db.RollbackTransactionAsync();
                    MessageBox.Show("Error al guardar Libro: " + ex.Message);
                }
            }
        }

        public async Task DeleteLibroAsync()
        {
            GetLibroSelected();

            if (_idLibro.Equals(0))
            {
                MessageBox.Show("Seleccione un libro!");
            }
            else
            {
                if (MessageBox.Show("Estás seguro de eliminar el Libro?",
                    "Eliminar Libro",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var db = new Conexion())
                    {
                        await _Libro
                                .Where(l => l.idLIBRO.Equals(_idLibro))
                                .DeleteAsync();
                    }
                }

                await ListLibroAsync();
            }
        }

        public Libro GetLibro(int idLibro)
        {
            using (var db = new Conexion())
            {
                return db._Libro.FirstOrDefault(l => l.idLIBRO == idLibro);
            }
        }

        public void GetLibroSelected()
        {
            if (_dataGridView.CurrentRow != null) 
            {
                _idLibro = Convert.ToInt32(_dataGridView.CurrentRow.Cells[0].Value);
            }
            else
            {
                _idLibro = 0;
            }
        }

        public void ChangeAction(string action)
        {
            _action = action;
        }
    }
}
