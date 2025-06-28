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
        public FormEditorial()
        {
            InitializeComponent();
            LoadComboPaises();

        }

        private void LoadComboPaises()
        {
                LPais lPais = new LPais();
                var getPaises = lPais.GetPaises();
                comboBoxPais.DataSource = getPaises;
                comboBoxPais.DisplayMember = "nombre";
                comboBoxPais.DataSource = "idPAIS";

        }
    }
}
