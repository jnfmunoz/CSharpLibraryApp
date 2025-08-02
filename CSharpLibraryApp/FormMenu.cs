using CSharpLibraryApp.Autor;
using CSharpLibraryApp.Editorial;
using CSharpLibraryApp.Genero;
using CSharpLibraryApp.Helpers;
using CSharpLibraryApp.Libro;
using CSharpLibraryApp.LibroAutor;
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
    public partial class FormMenu : MetroFramework.Forms.MetroForm
    {
        public FormMenu()
        {
            InitializeComponent();

            LabelHelper.BindClickToButton(labelAutor, metroButtonAutor);
            LabelHelper.BindClickAndFocus(labelAutor, metroButtonAutor);

            LabelHelper.BindClickToButton(labelEditorial, metroButtonEditorial);
            LabelHelper.BindClickAndFocus(labelEditorial, metroButtonEditorial);

            LabelHelper.BindClickToButton(labelGenero, metroButtonGenero);
            LabelHelper.BindClickAndFocus(labelGenero, metroButtonGenero);

            LabelHelper.BindClickToButton(labelLibro, metroButtonLibro);
            LabelHelper.BindClickAndFocus(labelLibro, metroButtonLibro);

            LabelHelper.BindClickToButton(labelLibroAutor, metroButtonLibroAutor);
            LabelHelper.BindClickAndFocus(labelLibroAutor, metroButtonLibroAutor);

        }

        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void metroButtonAutor_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormAutores();
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }

        private void metroButtonEditorial_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormEditoriales();
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }

        private void metroButtonGenero_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormGeneros();
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }

        private void metroButtonLibro_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormLibros();
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }

        private void metroButtonLibroAutor_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormLibrosAutores();
            form.FormClosed += (s, args) =>
            {
                this.Show();
            };

            form.Show();
        }
    }
}
