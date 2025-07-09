using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.Libro
{
    public partial class FormLibros : Form
    {
        private LLibro libro;
        public FormLibros()
        {
            InitializeComponent();

            Object[] objetos =
            {
                dataGridViewLibro
            };

            libro = new LLibro(objetos);

            this.Shown += async (s, e) =>
            {
                await libro.ListLibroAsync();
            };

        }
    }
}
 