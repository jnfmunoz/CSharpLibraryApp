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
using System.Windows.Forms;

namespace CSharpLibraryApp.LibroAutor
{
    public partial class FormLibrosAutores : MetroFramework.Forms.MetroForm
    {
        private LLibroAutor libroAutor;
        public FormLibrosAutores()
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
                dataGridViewLibroAutor
            };

            libroAutor = new LLibroAutor(obj);

            this.Shown += async (s, e) =>
            {
                await libroAutor.ListLibroAutorAsync();
                DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewLibroAutor);
            };
        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await libroAutor.SearchLibroAutorAsync(textBoxBuscar.Text.Trim());
        }

        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormLibroAutor();
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                await libroAutor.ListLibroAutorAsync();
            };
            form.Show();
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibroAutor.CurrentRow != null)
            {
                int idLibroAutor = Convert.ToInt32(dataGridViewLibroAutor.CurrentRow.Cells[0].Value);
                var form = new FormLibroAutor(idLibroAutor);
                this.Hide();

                form.FormClosed += async (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    await libroAutor.ListLibroAutorAsync();
                };
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecciona una asociación Libro - Autor de la tabla para editar.");
            }
        }

        private async void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            await libroAutor.DeleteLibroAutorAsync();
        }

        private void metroButtonAtras_Click(object sender, EventArgs e)
        {
            NavigationHelper.BackTo(this, new FormMenu());
        }
    }
}
