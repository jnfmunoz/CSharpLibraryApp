using Data;
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

        //public async Task<List<LibroDTO>> GetLibrosAutoresAsync(Conexion db)
        //{
            
        //}


    }
}
