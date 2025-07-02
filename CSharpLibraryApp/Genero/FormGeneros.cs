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

namespace CSharpLibraryApp.Genero
{
    public partial class FormGeneros : Form
    {
        private LGenero genero;
        public FormGeneros()
        {
            InitializeComponent();

            Object[] objetos =
            {
                dataGridViewGenero
            };

            genero = new LGenero(objetos);
            genero.ListGenero();

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            genero.SearchGenero(textBoxBuscar.Text.Trim());
        }

        private void buttonAgregarGenero_Click(object sender, EventArgs e)
        {
            /* método que también podría globalizar */
            this.Hide();

            var form = new FormGenero();
            form.FormClosed += (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                genero.ListGenero();
            };

            form.Show();
        }

        private void buttonEliminarGenero_Click(object sender, EventArgs e)
        {
            genero.DeleteGenero();
        }
    }
}
