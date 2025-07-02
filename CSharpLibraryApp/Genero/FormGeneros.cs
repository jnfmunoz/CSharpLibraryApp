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

            this.Shown += async (s, e) =>
            {
                await genero.ListGeneroAsync();
            };

        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await genero.SearchGeneroAsync(textBoxBuscar.Text.Trim());
        }

        private void buttonAgregarGenero_Click(object sender, EventArgs e)
        {
            /* método que también podría globalizar -> abrir y cerrar formularios */
            this.Hide();

            var form = new FormGenero();
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                await genero.ListGeneroAsync();
            };

            form.Show();
        }

        private async void buttonEliminarGenero_Click(object sender, EventArgs e)
        {
            await genero.DeleteGeneroAsync();
        }

        private void buttonEditarGenero_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenero.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewGenero.CurrentRow.Cells[0].Value);
                string nombre = dataGridViewGenero.CurrentRow.Cells[1].Value.ToString();

                LGenero lgenero = new LGenero();

                var form = new FormGenero();
                form.SetDataForUpdate(id, nombre);

                this.Hide();
                form.FormClosed += async (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    await genero.ListGeneroAsync();
                };
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un género literario!");
            }
        }


    }
}
