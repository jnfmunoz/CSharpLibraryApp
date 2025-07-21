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
using System.Transactions;
using System.Windows.Forms;

namespace CSharpLibraryApp.Genero
{
    public partial class FormGeneros : Form
    {
        private LGenero genero;
        public FormGeneros()
        {
            InitializeComponent();

            Object[] obj =
            {
                dataGridViewGenero
            };

            genero = new LGenero(obj);

            this.Shown += async (s, e) =>
            {
                await genero.ListGeneroAsync();
            };

            DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewGenero);
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await genero.SearchGeneroAsync(textBoxBuscar.Text.Trim());
        }

        private void buttonAgregarGenero_Click(object sender, EventArgs e)
        {
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

        private void buttonEditarGenero_Click(object sender, EventArgs e)
        {
            if (dataGridViewGenero.CurrentRow != null)
            {
                int idGenero = Convert.ToInt32(dataGridViewGenero.CurrentRow.Cells[0].Value);
                var form = new FormGenero(idGenero);
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
                MessageBox.Show("Selecciona un género de la tabla para editar.");
            }
        }

        private async void buttonEliminarGenero_Click(object sender, EventArgs e)
        {
            await genero.DeleteGeneroAsync();
        }
    }
}
