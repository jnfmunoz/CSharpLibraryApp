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
        public FormAutor()
        {
            InitializeComponent();
        }

        private void LoadComboPaises()
        {
            LPais lPais = new LPais();
            var getPaises = lPais.GetPaises();

            comboBoxPais.DataSource = getPaises;
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "idPAIS";
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // aqui quede
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error al agregar género: " + ex.Message);
            }
        }
    }
}
