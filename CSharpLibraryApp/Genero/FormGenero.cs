using Data;
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
    public partial class FormGenero : Form
    {
        private LGenero genero;

        public FormGenero()
        {
            InitializeComponent();

            genero = new LGenero();
        }

        public void SetDataForUpdate(int id, string nombre)
        {
            textBoxNombre.Text = nombre;

            genero.IdGenero = id;
            genero.ChangeAction("update");
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text.Trim();

                if (!string.IsNullOrEmpty(nombre))
                {
                    await genero.SaveGeneroAsync(nombre);
                    this.Close();                    
                }
                else
                {
                    MessageBox.Show("El nombre no puede estar vacío");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar género: " + ex.Message);
            }
        }


    }
}
