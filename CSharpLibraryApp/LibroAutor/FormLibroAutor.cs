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
    public partial class FormLibroAutor : Form
    {
        private LLibroAutor libroAutor;
        private LibroAutorInputModel _inputModel = new LibroAutorInputModel();
        private int _idLibroAutor = 0;

        public FormLibroAutor()
        {
            InitializeComponent();
            
        }

        public FormLibroAutor(int idLibroAutor) : this ()
        {
            _idLibroAutor = idLibroAutor;
        }

        private void FormLibroAutor_Load(object sender, EventArgs e)
        {
            if (_idLibroAutor == 0)
            {
                var libroAutorEntity = libroAutor.GetLibroAutor(_idLibroAutor);
                if (libroAutorEntity != null) 
                {
                    _inputModel = LibroAutorMapper.ToViewModel(libroAutorEntity);
                    /* AQUI QUEDE */
                }
            }

        }

        private void LoadComboLibro()
        {
            LLibro libro = new LLibro();
            comboBoxLibro.DataSource = libro.GetLibros();
            comboBoxLibro.DisplayMember = "titulo";
            comboBoxLibro.ValueMember = "idLIBRO";
        }

        private void LoadComboAutor()
        {
            LAutor autor = new LAutor();
            comboBoxAutor.DataSource = autor.GetAutores();
            comboBoxAutor.DisplayMember = "titulo";
            comboBoxAutor.ValueMember = "idLIBRO";
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


    }
}
