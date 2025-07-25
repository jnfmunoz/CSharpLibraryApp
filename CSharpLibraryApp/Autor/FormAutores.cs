using CSharpLibraryApp.Libro;
using Data;
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

namespace CSharpLibraryApp.Autor
{
    public partial class FormAutores : Form
    {
        private LAutor autor;
        public FormAutores()
        {
            InitializeComponent();

            Object[] obj =
            {
                dataGridViewAutor
            };

            autor = new LAutor(obj);

            this.Shown += async (s, e) =>
            {
                await autor.ListAutorAsync();
            };

            DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewAutor);
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await autor.SearchAutorAsync(textBoxBuscar.Text.Trim());
        }

        private void buttonAgregarAutor_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormAutor();
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                await autor.ListAutorAsync();
            };

            form.Show();
        }

        private void buttonEditarAutor_Click(object sender, EventArgs e)
        {
            if (dataGridViewAutor.CurrentRow != null)
            {
                int idAutor = Convert.ToInt32(dataGridViewAutor.CurrentRow.Cells[0].Value);
                var form = new FormAutor(idAutor);
                this.Hide();

                form.FormClosed += async (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    await autor.ListAutorAsync();
                };
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecciona un autor de la tabla para editar");
            }
        }

        private async void buttonEliminarAutor_Click(object sender, EventArgs e)
        {
            await autor.DeleteAutorAsync();
        }
    }
}
