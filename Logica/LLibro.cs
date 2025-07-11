using Data;
using LinqToDB;
using Logica.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica.DTOs;
using Org.BouncyCastle.Crypto;

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
                                 join e in db.GetTable<Editorial>()
                                    on l.EDITORIAL_idEDITORIAL equals e.idEDITORIAL
                                 join g in db.GetTable<Genero>()
                                    on l.GENERO_idGENERO equals g.idGENERO
                                 join la in db.GetTable<LibroAutor>()
                                    on l.idLIBRO equals la.LIBRO_idLIBRO
                                 join a in db.GetTable<Autor>()
                                    on la.AUTOR_idAUTOR equals a.idAUTOR
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
                                 }).ToListAsync();

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
                    _dataGridView.Columns["AnioPublicacion"].HeaderText = "Año de publicación";

                    foreach (DataGridViewColumn col in _dataGridView.Columns)
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
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
                        if (!string.IsNullOrEmpty(field))
                        {
                            libros = libros.Where(l =>
                                l.ID.ToString().Contains(field) ||
                                (l.Titulo != null && l.Titulo.ToLower().Contains(field.ToLower())) ||
                                (l.ISBN != null && l.ISBN.ToLower().Contains(field.ToLower())) ||
                                l.AnioPublicacion.ToString().Contains(field) ||
                                (l.Sinopsis != null && l.Sinopsis.ToLower().Contains(field.ToLower())) ||
                                (l.Editorial != null && l.Editorial.ToLower().Contains(field.ToLower())) ||
                                (l.Genero != null && l.Genero.ToLower().Contains(field.ToLower())) ||
                                (l.Autor != null && l.Autor.ToLower().Contains(field.ToLower()))
                            ).ToList();
                        }

                        _dataGridView.DataSource = libros;
                        _dataGridView.Columns["Titulo"].HeaderText = "Año de publicación";
                        _dataGridView.Columns["AnioPublicacion"].HeaderText = "Año de publicación";
                        _dataGridView.Columns["AnioPublicacion"].HeaderText = "Año de publicación";

                        foreach (DataGridViewColumn col in _dataGridView.Columns)
                        {
                            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar libro: " + ex.Message);
            }
        }

        public async Task SaveLibroAsync()
        {
            // COMMIT 19
        }

    }
}
