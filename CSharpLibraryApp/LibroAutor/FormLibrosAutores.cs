using Logica;
using Logica.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.LibroAutor
{
    public partial class FormLibrosAutores : Form
    {
        private LLibroAutor libroAutor;
        public FormLibrosAutores()
        {
            InitializeComponent();

            Object[] obj =
            {
                dataGridViewLibroAutor
            };

            libroAutor = new LLibroAutor(obj);

            this.Shown += async (s, e) =>
            {
                await libroAutor.ListLibroAutorAsync();
            };

            DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewLibroAutor);
        }
    }
}
