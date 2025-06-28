using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        private void buttonAgregarEditorial_Click(object sender, EventArgs e)
        {
            this.Hide();  // Ocultamos el formulario actual (FormEditoriales)

            var form = new FormEditorial();
            form.FormClosed += (s, args) =>
            {
                this.Show();               // Mostramos FormEditoriales cuando se cierre FormEditorial
                editorial.ListEditorial(); // Refrescamos la lista
            };

            form.Show(); // Abrimos FormEditorial de forma no modal para que el código siga
        }

        private void RefreshEditorial(object sender, FormClosedEventArgs e)
        {
            editorial.ListEditorial();
        }

    }
}
