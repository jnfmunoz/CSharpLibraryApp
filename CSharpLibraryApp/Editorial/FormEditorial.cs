using Data;
using Logica;
using Logica.Mappers;
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

namespace CSharpLibraryApp.Editorial
{
    public partial class FormEditorial : Form
    {
        private LEditorial editorial = new LEditorial();
        private EditorialInputModel _inputModel = new EditorialInputModel();
        private int _idEditorial = 0;

        public FormEditorial()
        {
            InitializeComponent();
            this.Load += FormEditorial_Load;
        }

        public FormEditorial (int idEditorial) : this()
        {
            _idEditorial = idEditorial;
        }

        private void FormEditorial_Load(object sender, EventArgs e)
        {
            if (_idEditorial > 0)
            {
                var editorialEntity = editorial.GetEditorial(_idEditorial);

                if (editorialEntity != null)
                {
                    _inputModel = EditorialMapper.ToViewModel(editorialEntity);
                    MapToUI(_inputModel);                    
                    editorial.idEditorial = _idEditorial;
                    editorial.ChangeAction("update");
                }
                else
                {
                    MessageBox.Show("Editorial no encontrada.");
                    this.Close();
                }
            }
            else 
            {
                editorial.ChangeAction("insert");
            }
        }

        private void LoadComboPais()
        {
            LPais pais = new LPais();

            comboBoxPais.DataSource = pais.GetPaises();
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "idPAIS";
        }

        private void MapToUI(EditorialInputModel model)
        {
            textBoxNombre.Text = model.Editorial ?? "";

        }

    }
}
