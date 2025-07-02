using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp
{
    public partial class FormEditoriales : Form
    {
        private LEditorial editorial;
        public FormEditoriales()
        {
            InitializeComponent();

            Object[] objetos =
            {
                dataGridViewEditorial
            };

            editorial = new LEditorial(objetos);
            editorial.ListEditorial();

        }

        private void buttonAgregarEditorial_Click(object sender, EventArgs e)
        {
            this.Hide();  

            var form = new FormEditorial();
            form.FormClosed += (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                editorial.ListEditorial();
            };

            form.Show(); 
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            editorial.DeleteEditorial();
        }

        private void buttonEditarEditorial_Click(object sender, EventArgs e)
        {
            if (dataGridViewEditorial.CurrentRow != null)
            {
                int id = Convert.ToInt32(dataGridViewEditorial.CurrentRow.Cells[0].Value);
                string nombre = dataGridViewEditorial.CurrentRow.Cells[1].Value.ToString();
                string nombrePais = dataGridViewEditorial.CurrentRow.Cells[2].Value.ToString();

                LPais lPais = new LPais();
                int idPais = lPais.GetIdPaisFromName(nombrePais);

                if (idPais == 0)
                {
                    MessageBox.Show("No se pudo encontrar el país asociado");
                    return;
                }

                var form = new FormEditorial();
                form.SetDataForUpdate(id, nombre, idPais);

                this.Hide();
                form.FormClosed += (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    editorial.ListEditorial();
                };
                form.Show();

            }
            else
            {
                MessageBox.Show("Selecciona una Editorial!");
            }

        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            editorial.SearchEditorial(textBoxBuscar.Text.Trim());
        }
    }
}
