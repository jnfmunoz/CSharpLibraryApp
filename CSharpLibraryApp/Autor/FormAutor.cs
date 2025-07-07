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
    public partial class FormAutor : Form
    {
        private LAutor autor;

        public FormAutor()
        {
            InitializeComponent();
            LoadComboPaises();

            autor = new LAutor();

        }

        private void LoadComboPaises()
        {
            LPais lPais = new LPais();
            var getPaises = lPais.GetPaises();

            comboBoxPais.DataSource = getPaises;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "idPAIS";
        }

        public void SetDataForUpdate(int id, string nombre, DateTime fechaNacimiento, int idPais)
        {
            textBoxNombre.Text = nombre;
            dateTimePickerFechaNacimiento.Value = fechaNacimiento;
            comboBoxPais.SelectedValue = idPais;

            autor.IdAutor = id;
            autor.ChangeAction("update");

        }

        private async void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text.Trim();
                DateTime fechaNacimiento = dateTimePickerFechaNacimiento.Value;

                if (comboBoxPais.SelectedValue != null)
                {                    
                    int idPais = (int)comboBoxPais.SelectedValue;

                    await autor.SaveAutorAsync(nombre, fechaNacimiento, idPais);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona un país válido!");
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar autor: " + ex.Message);
            }
        }
    }
}
