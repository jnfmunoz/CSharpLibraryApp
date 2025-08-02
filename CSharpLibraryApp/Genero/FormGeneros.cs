using CSharpLibraryApp.Helpers;
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
    public partial class FormGeneros : MetroFramework.Forms.MetroForm
    {
        private LGenero genero;
        public FormGeneros()
        {
            InitializeComponent();

            LabelHelper.BindClickToButton(labelAgregar, metroButtonAgregar);
            LabelHelper.BindClickAndFocus(labelAgregar, metroButtonAgregar);

            LabelHelper.BindClickToButton(labelEditar, metroButtonEditar);
            LabelHelper.BindClickAndFocus(labelEditar, metroButtonEditar);

            LabelHelper.BindClickToButton(labelEliminar, metroButtonEliminar);
            LabelHelper.BindClickAndFocus(labelEliminar, metroButtonEliminar);

            LabelHelper.BindClickToButton(labelAtras, metroButtonAtras);
            LabelHelper.BindClickAndFocus(labelAtras, metroButtonAtras);

            Object[] obj =
            {
                dataGridViewGenero
            };

            genero = new LGenero(obj);

            this.Shown += async (s, e) =>
            {
                await genero.ListGeneroAsync();
                DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewGenero);
            };
        }

        private void metroButtonAgregar_Click(object sender, EventArgs e)
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

        private void metroButtonEditar_Click(object sender, EventArgs e)
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

        private async void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            await genero.DeleteGeneroAsync();
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await genero.SearchGeneroAsync(textBoxBuscar.Text.Trim());
        }

        private void metroButtonAtras_Click(object sender, EventArgs e)
        {
            NavigationHelper.BackTo(this, new FormMenu());
        }
    }
}
