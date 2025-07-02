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
    }
}
