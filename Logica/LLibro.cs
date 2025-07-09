using Data;
using LinqToDB;
using Logica.Library;
using Org.BouncyCastle.Crypto.Operators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

        public async Task ListLibroAsync()
        {
            try
            {
                using (var db = new Conexion())
                {
                    var list = await (
                        from l in db.GetTable<Libro>()
                        join e in db.GetTable<Editorial>() 
                            on l.EDITORIAL_idEDITORIAL equals e.idEDITORIAL
                        join g in db.GetTable<Genero>() 
                            on l.GENERO_idGENERO equals g.idGENERO
                        join la in db.GetTable<LibroAutor>() 
                            on l.idLIBRO equals la.LIBRO_idLIBRO 
                            into libroAutores
                        from la in libroAutores.DefaultIfEmpty()
                        join a in db.GetTable<Autor>() 
                            on la.AUTOR_idAUTOR equals a.idAUTOR 
                            into autores
                        from a in autores.DefaultIfEmpty()
                        group a by new
                        {
                            l.idLIBRO,
                            l.titulo,
                            l.isbn,
                            l.anio_publicacion,
                            l.sinopsis,
                            Editorial = e.nombre,
                            Género = g.nombre
                        }
                        into grouped
                        orderby grouped.Key.idLIBRO
                        select new
                        {
                            ID = grouped.Key.idLIBRO,
                            Título = grouped.Key.titulo,
                            ISBN = grouped.Key.isbn,
                            AnioPublicacion = grouped.Key.anio_publicacion,
                            Sinopsis = grouped.Key.sinopsis,
                            grouped.Key.Editorial,
                            grouped.Key.Género,
                            Autor = string.Join(", ", grouped.Where(a => a != null).Select(a => a.nombre).Distinct())
                        }
                    ).ToListAsync();

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


    }
}
