using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica.Helpers
{
    public static class DataGridViewHelper
    {
        public static void AutoResizeColumns(DataGridView dgv)
        {
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        public static void SetupDataGridViewDefaults(DataGridView dgv)
        {
            dgv.CurrentCell = null;
        }

        public static void RenameHeaderTextTitulo(DataGridView dgv)
        {
            dgv.Columns["Titulo"].HeaderText = "Título";
        }
        public static void RenameHeaderTextAnioPublicacion(DataGridView dgv)
        {
            dgv.Columns["AnioPublicacion"].HeaderText = "Año de publicación";
        }

        public static void RenameHeaderTextAnioGenero(DataGridView dgv)
        {
            dgv.Columns["Genero"].HeaderText = "Género";
        }

        public static void RenameHeaderTextPais(DataGridView dgv)
        {
            dgv.Columns["Pais"].HeaderText = "País";
        }

        public static void RenameHeaderTextGenero(DataGridView dgv)
        {
            dgv.Columns["Genero"].HeaderText = "Género";
        }

    }
}
