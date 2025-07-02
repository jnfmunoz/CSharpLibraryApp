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

namespace CSharpLibraryApp
{
    public partial class FormEditorial : Form
    {
        private LEditorial editorial;

        public FormEditorial()
        {
            InitializeComponent();
            LoadComboPaises();

            editorial = new LEditorial();

        }

        private void LoadComboPaises()
        {
            LPais lPais = new LPais();
            var getPaises = lPais.GetPaises();

            comboBoxPais.DataSource = getPaises;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "idPAIS";

        }

        public void SetDataForUpdate(int id, string nombre, int idPais)
        {
            textBoxNombre.Text = nombre;
            comboBoxPais.SelectedValue = idPais;
            
            editorial.IdEditorial = id;
            editorial.ChangeAction("update");

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = textBoxNombre.Text.Trim();
                if (comboBoxPais.SelectedValue != null)
                {
                    int idPais = (int)comboBoxPais.SelectedValue;

                    editorial.SaveEditorial(nombre, idPais);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Selecciona un país válido.");
                }



            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la editorial: " + ex.Message);
            }
        }
    }
}
