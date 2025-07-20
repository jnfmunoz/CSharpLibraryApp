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

namespace CSharpLibraryApp.Genero
{
    public partial class FormGenero : Form
    {
        private LGenero genero = new LGenero();
        private GeneroInputModel _inputModel = new GeneroInputModel();
        private int _idGenero = 0;

        public FormGenero()
        {
            InitializeComponent();
            this.Load += FormGenero_Load;

        }

        public FormGenero(int idGenero) : this()
        {
            _idGenero = idGenero;
        }

        private void FormGenero_Load(object sender, EventArgs e)
        {
            if (_idGenero > 0)
            {
                var generoEntity = genero.GetGenero(_idGenero);

                if (generoEntity != null)
                {
                    _inputModel = GeneroMapper.ToViewModel(generoEntity);
                    MapToUI(_inputModel);

                    genero.idGenero = _idGenero;
                    genero.ChangeAction("update");
                }
                else
                {
                    MessageBox.Show("Género no encontrado.");
                    this.Close();
                }
            }
            else
            {
                genero.ChangeAction("insert");
            }
        }

        private void MapToUI(GeneroInputModel model)
        {
            textBoxNombre.Text = model.Genero ?? "";
        }

        private void MapFromUI(GeneroInputModel model)
        {
            model.Genero = textBoxNombre.Text.Trim();
        }

        private async Task buttonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MapFromUI(_inputModel);
                //await 
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el género: " + ex.Message);
            }
        }
    }
}
