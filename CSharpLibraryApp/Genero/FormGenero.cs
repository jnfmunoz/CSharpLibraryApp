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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text.Trim();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    genero.SaveGenero(nombre);
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
