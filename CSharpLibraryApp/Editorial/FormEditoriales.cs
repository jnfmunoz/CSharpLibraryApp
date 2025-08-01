using CSharpLibraryApp.Helpers;
using Logica;
using Logica.Helpers;
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
    public partial class FormEditoriales : MetroFramework.Forms.MetroForm
    {
        private LEditorial editorial;
        public FormEditoriales()
        {
            InitializeComponent();

            LabelHelper.BindClickToButton(labelAgregar, metroButtonAgregar);
            LabelHelper.BindClickAndFocus(labelAgregar, metroButtonAgregar);

            LabelHelper.BindClickToButton(labelEditar, metroButtonEditar);
            LabelHelper.BindClickAndFocus(labelEditar, metroButtonEditar);

            LabelHelper.BindClickToButton(labelEliminar, metroButtonEliminar);
            LabelHelper.BindClickAndFocus(labelEliminar, metroButtonEliminar);

            LabelHelper.BindClickToButton(labelAtras, metroButtonAtras);
            LabelHelper.BindClickAndFocus(labelAtras, metroButtonAtras);

            Object[] obj =
            {
                dataGridViewEditorial
            };

            editorial = new LEditorial(obj);

            this.Shown += async (s, e) =>
            {
                await editorial.ListEditorialAsync();
            };

            DataGridViewHelper.SetupDataGridViewDefaults(dataGridViewEditorial);            
        }

        private async void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            await editorial.SearchEditorialAsync(textBoxBuscar.Text.Trim());
        }

        private void metroButtonAgregar_Click(object sender, EventArgs e)
        {
            this.Hide();

            var form = new FormEditorial();
            form.FormClosed += async (s, args) =>
            {
                this.Show();
                textBoxBuscar.Text = "";
                await editorial.ListEditorialAsync();
            };
            form.Show();
        }

        private void metroButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEditorial.CurrentRow != null)
            {
                int idEditorial = Convert.ToInt32(dataGridViewEditorial.CurrentRow.Cells[0].Value);
                var form = new FormEditorial(idEditorial);
                this.Hide();

                form.FormClosed += async (s, args) =>
                {
                    this.Show();
                    textBoxBuscar.Text = "";
                    await editorial.ListEditorialAsync();
                };
                form.Show();
            }
            else
            {
                MessageBox.Show("Selecciona una editorial");
            }
        }

        private async void metroButtonEliminar_Click(object sender, EventArgs e)
        {
            await editorial.DeleteEditorialAsync();
        }
    }
}
