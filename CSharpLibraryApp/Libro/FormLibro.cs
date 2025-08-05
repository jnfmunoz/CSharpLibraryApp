using Data;
using LinqToDB.Data.RetryPolicy;
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

namespace CSharpLibraryApp.Libro
{
    public partial class FormLibro : MetroFramework.Forms.MetroForm
    {
        private LLibro libro;
        private LibroInputModel _inputModel = new LibroInputModel();
        private int _idLibro = 0;

        public FormLibro()
        {
            InitializeComponent();
            this.Load += FormLibro_Load;
            LoadComboEditorial();
            LoadComboGenero();

            libro = new LLibro();
        }

        public FormLibro(int idLibro) : this()
        {
            _idLibro = idLibro;
        }

        private void FormLibro_Load(object  sender, EventArgs e)
        {
            if (_idLibro > 0)
            {
                var libroEntity = libro.GetLibro(_idLibro);
                if(libroEntity != null)
                {
                    _inputModel = LibroMapper.ToViewModel(libroEntity);
                    MapToUI(_inputModel);

                    libro.idLibro = _idLibro;
                    libro.ChangeAction("update");
                }
                else
                {
                    MessageBox.Show("Libro no encontrado.");
                    this.Close();
                }
            }
            else
            {
                libro.ChangeAction("insert");
            }
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

        private void MapToUI(LibroInputModel model)
        {
            textBoxTitulo.Text = model.Titulo ?? "";
            textBoxIsbn.Text = model.ISBN ?? "";
            textBoxAnioPublicacion.Text = model.AnioPublicacion.ToString() ?? "";
            textBoxSinopsis.Text = model.Sinopsis ?? "";
            comboBoxEditorial.SelectedValue = model.EDITORIAL_idEDITORIAL;
            comboBoxGenero.SelectedValue = model.GENERO_idGENERO;
        }

        private void MapFromUI(LibroInputModel model)
        {
            model.Titulo = textBoxTitulo.Text.Trim();
            model.ISBN = textBoxIsbn.Text.Trim();
            model.AnioPublicacion = Convert.ToInt32(textBoxAnioPublicacion.Text.Trim());
            model.Sinopsis = textBoxSinopsis.Text.Trim();
            model.EDITORIAL_idEDITORIAL = Convert.ToInt32(comboBoxEditorial.SelectedValue);
            model.GENERO_idGENERO = Convert.ToInt32(comboBoxGenero.SelectedValue);            
        }

        private async void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MapFromUI(_inputModel);

                if (_inputModel.EDITORIAL_idEDITORIAL == 0 || _inputModel.GENERO_idGENERO == 0)
                {
                    MessageBox.Show("Selecciona un editorial y un género válidos.");
                    return;
                }

                await libro.SaveLibroAsync(_inputModel);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar libro: " + ex.Message);
            }
        }
    }
}
