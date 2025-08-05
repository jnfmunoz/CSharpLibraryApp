using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.Helpers
{
    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(MetroForm owner,
    //        string message,
    //        string title = "Mensaje",
    //        MessageBoxButtons buttons = MessageBoxButtons.OK,
    //        MessageBoxIcon icon = MessageBoxIcon.Information)
    //    {
    //        Form overlay = new Form();
    //        overlay.StartPosition = FormStartPosition.Manual;
    //        overlay.FormBorderStyle = FormBorderStyle.None;
    //        overlay.Opacity = 0.5;
    //        overlay.BackColor = Color.Black;
    //        overlay.WindowState = FormWindowState.Maximized;
    //        overlay.TopMost = true;
    //        overlay.ShowInTaskbar = false;

    //        overlay.Show(owner);

    //        MetroMessageBox.Show(owner, message, title, buttons, icon);
    //        overlay.Close();
    //        overlay.Dispose();
    //    }
    //}

    public static class MetroMessageHelper
    {
        public static void ShowWithOverlay(
                Form parent,
                string message,
                string title,
                MessageBoxButtons buttons,
                MessageBoxIcon icon)
        {
                // Crear overlay con color personalizado
                var overlay = new Panel
                {
                    Dock = DockStyle.Fill,
                    BackColor = Color.FromArgb(128, 30, 9, 102), // 50% de opacidad con tu color
                    Visible = true
                };

                parent.Controls.Add(overlay);
                overlay.BringToFront();

                try
                {
                    // Mostrar mensaje Metro
                    MetroFramework.MetroMessageBox.Show(parent, message, title, buttons, icon);
                }
                finally
                {
                    // Quitar overlay
                    parent.Controls.Remove(overlay);
                    overlay.Dispose();
                }
        }
    }

}
