using CSharpLibraryApp.Helpers;
using CSharpLibraryApp.Libro;
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

namespace CSharpLibraryApp.Libro
{
    public partial class FormLibros : MetroFramework.Forms.MetroForm
    {
        private LLibro libro;
        public FormLibros()
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

            Object[] objetos =
            {
                dataGridViewLibro
            };

            libro = new LLibro(objetos);            

            this.Shown += async (s, e) =>
            {
                await libro.ListLibroAsync();
            };

            DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewLibro);
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await libro.SearchLibroAsync(textBoxBuscar.Text.Trim());
        }

        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormLibro();
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                await libro.ListLibroAsync();
            };

            form.Show();
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewLibro.CurrentRow != null)
            {
                int idLibro = Convert.ToInt32(dataGridViewLibro.CurrentRow.Cells[0].Value);
                var form = new FormLibro(idLibro);
                this.Hide();

                form.FormClosed += async (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    await libro.ListLibroAsync();
                };
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un libro de la tabla para editar.");
            }
        }

        private async void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            await libro.DeleteLibroAsync();
        }
    }
}
