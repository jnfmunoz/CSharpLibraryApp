using CSharpLibraryApp.Autor;
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

namespace CSharpLibraryApp.Autor
{
    public partial class FormAutores : Form
    {
        private LAutor autor;
        public FormAutores()
        {
            InitializeComponent();

            Object[] objetos =
            {
                dataGridViewAutor
            };

            autor = new LAutor(objetos);

            this.Shown += async (s, e) =>
            {
                await autor.ListAutorAsync();
            };

        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await autor.SearchAutorAsync(textBoxBuscar.Text.Trim());
        }

        private async void buttonEliminarAutor_Click(object sender, EventArgs e)
        {
            await autor.DeleteAutorAsync();
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
                int id = Convert.ToInt32(dataGridViewAutor.CurrentRow.Cells[0].Value);
                string nombre = dataGridViewAutor.CurrentRow.Cells[1].Value.ToString();
                DateTime fechaNacimiento = Convert.ToDateTime(dataGridViewAutor.CurrentRow.Cells[2].Value);
                string pais = dataGridViewAutor.CurrentRow.Cells[3].Value.ToString();

                LPais lPais = new LPais();
                int idPais = lPais.GetIdPaisFromName(pais);

                var form = new FormAutor();
                form.SetDataForUpdate(id, nombre, fechaNacimiento, idPais);

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
                MessageBox.Show("Selecciona un autor!");
            }
        }
    }
}