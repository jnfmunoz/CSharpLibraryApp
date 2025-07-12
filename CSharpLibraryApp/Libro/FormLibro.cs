using Data;
using Logica;
using Logica.ViewModels;
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
    public partial class FormLibro : Form
    {
        private LLibro libro;
        public FormLibro()
        {
            InitializeComponent();
            LoadComboEditorial();
            LoadComboGenero();

            libro = new LLibro();
        }

        private void LoadComboEditorial()
        {
            LEditorial editorial = new LEditorial();            

            comboBoxEditorial.DataSource = editorial.GetEditoriales();
            comboBoxEditorial.DisplayMember = "nombre";
            comboBoxEditorial.ValueMember = "idEDITORIAL";
        }

        private void LoadComboGenero()
        {
            LGenero genero = new LGenero();

            comboBoxGenero.DataSource = genero.GetGeneros();
            comboBoxGenero.DisplayMember = "nombre";
            comboBoxGenero.ValueMember = "idGENERO";
        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string titulo = textBoxTitulo.Text.Trim();
                string isbn = textBoxIsbn.Text.Trim();
                int anioPublicacion = Convert.ToInt32(textBoxAnioPublicacion.Text.Trim());
                string sinopsis = textBoxSinopsis.Text.Trim();


                if (comboBoxEditorial.SelectedValue != null && comboBoxGenero.SelectedValue != null)
                {
                    int idEditorial = (int)comboBoxEditorial.SelectedValue;
                    int idGenero = (int)comboBoxGenero.SelectedValue;

                    var input = new LibroInputModel
                    {
                        Titulo = titulo,
                        ISBN = isbn,
                        AnioPublicacion = anioPublicacion,
                        Sinopsis = sinopsis,
                        EDITORIAL_idEDITORIAL = idEditorial,
                        GENERO_idGENERO = idGenero
                    };

                    await libro.SaveLibroAsync(input);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona un país válido.");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar libro: " + ex.Message);
            }
        }
    }
}
