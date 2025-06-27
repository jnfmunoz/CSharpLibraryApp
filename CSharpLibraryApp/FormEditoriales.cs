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

namespace CSharpLibraryApp
{
    public partial class FormEditoriales : Form
    {
        private LEditorial editorial;
        public FormEditoriales()
        {
            InitializeComponent();

            Object[] objetos =
            {
                dataGridViewEditorial
            };

            editorial = new LEditorial(objetos);
            editorial.ListEditorial();

        }

    }
}
