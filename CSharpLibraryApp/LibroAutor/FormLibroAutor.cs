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

namespace CSharpLibraryApp.LibroAutor
{        
    public partial class FormLibroAutor : MetroFramework.Forms.MetroForm
    {
        private LLibroAutor libroAutor;
        private LibroAutorInputModel _inputModel = new LibroAutorInputModel();
        private int _idLibroAutor = 0;

        public FormLibroAutor()
        {
            InitializeComponent();
            this.Load += FormLibroAutor_Load;            

            libroAutor = new LLibroAutor();
        }

        public FormLibroAutor(int idLibroAutor) : this()
        {
            _idLibroAutor = idLibroAutor;
        }

        private void FormLibroAutor_Load(object sender, EventArgs e)
        {
            if (_idLibroAutor > 0)
            {
                LoadComboLibro();
                LoadComboAutor();

                var libroAutorEntity = libroAutor.GetLibroAutor(_idLibroAutor);
                if (libroAutorEntity != null)
                {
                    _inputModel = LibroAutorMapper.ToViewModel(libroAutorEntity);
                    MapToUI(_inputModel);

                    libroAutor.idLibroAutor = _idLibroAutor;
                    libroAutor.ChangeAction("update");
                }
                else
                {
                    MessageBox.Show("Asociación Libro - Autor no encontrada.");
                    this.Close();
                }
            }
            else
            {
                LoadComboLibroWithoutAutor();
                LoadComboAutor();
                libroAutor.ChangeAction("insert");
            }
        }
        
        private void LoadComboLibro()
        {
            LLibro libro = new LLibro();
            comboBoxLibro.DataSource = libro.GetLibros();
            comboBoxLibro.DisplayMember = "titulo";
            comboBoxLibro.ValueMember = "idLIBRO";
        }

        private void LoadComboLibroWithoutAutor()
        {
            LLibro libro = new LLibro();
            comboBoxLibro.DataSource = libro.GetLibrosWithoutAutor();
            comboBoxLibro.DisplayMember = "titulo";
            comboBoxLibro.ValueMember = "idLIBRO";
        }

        private void LoadComboAutor()
        {
            LAutor autor = new LAutor();
            comboBoxAutor.DataSource = autor.GetAutores();
            comboBoxAutor.DisplayMember = "nombre";
            comboBoxAutor.ValueMember = "idAUTOR";
        }

        private void MapToUI(LibroAutorInputModel model)
        {
            comboBoxLibro.SelectedValue = model.Libro;
            comboBoxAutor.SelectedValue = model.Autor;
        }

        private void MapFromUI(LibroAutorInputModel model)
        {
            model.Libro = Convert.ToInt32(comboBoxLibro.SelectedValue);
            model.Autor = Convert.ToInt32(comboBoxAutor.SelectedValue);
        }

        private async void metroButtonGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                MapFromUI(_inputModel);

                if (_inputModel.Libro == 0 || _inputModel.Autor == 0)
                {
                    MessageBox.Show("Selecciona un libro y un autor válidos.");
                    return;
                }

                await libroAutor.SaveLibroAutor(_inputModel);
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar asociación Libro - Autor: " + ex.Message);
            }
        }
    }
}
