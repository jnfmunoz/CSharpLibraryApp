using Data;
using LinqToDB;
using Logica.DTOs;
using Logica.Library;
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
                             Autor = group.Key.l,
                             Libro = group.Key.a
                         })
                         .ToList();
            return result;                         
        }


    }
}
