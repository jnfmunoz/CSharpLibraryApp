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

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await libroAutor.SearchLibroAutorAsync(textBoxBuscar.Text.Trim());
        }

        private void buttonAgregarLibroAutor_Click(object sender, EventArgs e)
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

        private void buttonEditarLibroAutor_Click(object sender, EventArgs e)
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

        private async void buttonEliminarLibroAutor_Click(object sender, EventArgs e)
        {
            await libroAutor.DeleteLibroAutorAsync();
        }
    }
}
