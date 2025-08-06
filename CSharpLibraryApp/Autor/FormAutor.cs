using Google.Protobuf.WellKnownTypes;
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
using MetroFramework;
using CSharpLibraryApp.Helpers;

namespace CSharpLibraryApp.Autor
{
    public partial class FormAutor : MetroFramework.Forms.MetroForm
    {
        private LAutor autor = new LAutor();
        private AutorInputModel _inputModel = new AutorInputModel();
        private int _idAutor = 0;

        public FormAutor()
        {
            InitializeComponent();
            this.Load += FormAutor_Load;
            LoadComboPais();
        }

        public FormAutor(int idAutor) : this()
        { 
            _idAutor = idAutor;
        }

        private void FormAutor_Load(object sender, EventArgs e)
        {
            if (_idAutor > 0)
            {
                var autorEntity = autor.GetAutor(_idAutor);

                if (autorEntity != null)
                {
                    _inputModel = AutorMapper.ToViewModel(autorEntity);
                    MapToUI(_inputModel);

                    autor.idAutor = _idAutor;
                    autor.ChangeAction("update");
                }
                else
                {
                    MessageBox.Show("Autor no encontrado.");
                    this.Close();
                }
            }
            else
            {
                autor.ChangeAction("insert");
            }
        }

        private void LoadComboPais()
        {
            LPais pais = new LPais();

            comboBoxPais.DataSource = pais.GetPaises();
            comboBoxPais.DisplayMember = "nombre";
            comboBoxPais.ValueMember = "idPAIS";
        }

        private void MapToUI(AutorInputModel model)
        {
            textBoxNombre.Text = model.Nombre ?? "";
            comboBoxPais.SelectedValue = model.Pais;
            dateTimePickerFechaNacimiento.Value = model.FechaNacimiento;
        }

        private void MapFromUI(AutorInputModel model)
        {
            model.Nombre = textBoxNombre.Text.Trim();
            model.Pais = Convert.ToInt32(comboBoxPais.SelectedValue);
            model.FechaNacimiento = dateTimePickerFechaNacimiento.Value;
        }
        
        private async void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MapFromUI(_inputModel);

                if (_inputModel.Pais == 0)
                {
                    //MessageBox.Show("Selecciona un país válido");

                    //MetroFramework.MetroMessageBox.Show(
                    //    this,
                    //    "Selecciona un país válido",
                    //    "Advertencia",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Warning
                    //);

                    //MetroMessageHelper.ShowWithOverlay(
                    //    this,
                    //    "Selecciona un país válido",
                    //    "Advertencia",
                    //    MessageBoxButtons.OK,
                    //    MessageBoxIcon.Warning
                    //);

                    //MetroMessageHelper.ShowWithOverlay(
                    //    this,
                    //    "Selecciona un país válido"
                    //);  

                    MetroMessageHelper.ShowWithOverlay(this, "Selecciona un país válido");

                    return;
                }

                //await autor.SaveAutorAsync(_inputModel);
                //this.Close();
                
                var (success, message) = await autor.SaveAutorAsync(_inputModel);

                //MetroMessageHelper.ShowWithOverlay(
                //    this,
                //    message,
                //    success ? "Éxito" : "Error",
                //    MessageBoxButtons.OK,
                //    success ? MessageBoxIcon.Information : MessageBoxIcon.Error
                //);

                //MetroMessageHelper.ShowWithOverlay(
                //        this,
                //        message
                //);

                MetroMessageHelper.ShowWithOverlay(this, message);

                if (success)
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error al guardar autor: " + ex.Message);

                //MetroMessageHelper.ShowWithOverlay(
                //    this,
                //    "Error al guardar autor: " + ex.Message,
                //    "Error",
                //    MessageBoxButtons.OK,
                //    MessageBoxIcon.Error
                //);

                //MetroMessageHelper.ShowWithOverlay(
                //        this,
                //        "Error al guardar autor: " + ex.Message
                //);

                MetroMessageHelper.ShowWithOverlay(this, "Error al guardar autor: " + ex.Message);
            }
        }
    }
}
