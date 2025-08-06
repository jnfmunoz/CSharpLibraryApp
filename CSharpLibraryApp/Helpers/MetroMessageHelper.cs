using CSharpLibraryApp.UserControls;
using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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

    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(
    //            Form parent,
    //            string message,
    //            string title,
    //            MessageBoxButtons buttons,
    //            MessageBoxIcon icon)
    //    {
    //        // Crear overlay con color personalizado
    //        var overlay = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            BackColor = Color.FromArgb(128, 30, 9, 102), // 50% de opacidad con tu color
    //            Visible = true
    //        };

    //        parent.Controls.Add(overlay);
    //        overlay.BringToFront();

    //        try
    //        {
    //            // Mostrar mensaje Metro
    //            MetroFramework.MetroMessageBox.Show(parent, message, title, buttons, icon);
    //        }
    //        finally
    //        {
    //            // Quitar overlay
    //            parent.Controls.Remove(overlay);
    //            overlay.Dispose();
    //        }
    //    }
    //}


    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(Form parent, string message)
    //    {
    //        var overlay = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            BackColor = Color.FromArgb(128, 30, 90, 102),
    //            Visible = true
    //        };

    //        parent.Controls.Add(overlay);
    //        overlay.BringToFront();

    //        var notification = new MetroPrimaryButtoncs
    //        {
    //            TextMessage = message,
    //            BackColor = Color.White,
    //        };

    //        overlay.Controls.Add(notification);
    //        notification.BringToFront();

    //        var timer = new Timer { Interval = 2000 };
    //        timer.Tick += (s, e) =>
    //        {
    //            timer.Stop();
    //            overlay.Dispose();
    //        };

    //        timer.Start();

    //    }

    //}

    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(MetroForm owner, string message)
    //    {
    //        // Crear overlay semi-transparente
    //        Panel overlay = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            BackColor = Color.FromArgb(128, 30, 9, 102), // 50% opacidad
    //        };

    //        owner.Controls.Add(overlay);
    //        overlay.BringToFront();
    //        overlay.Visible = true;
    //        overlay.Focus();

    //        // Crear instancia de tu UserControl
    //        var notification = new MetroPrimaryButtoncs
    //        {
    //            TextMessage = message,  // tu label dinámico
    //            Dock = DockStyle.None,
    //        };

    //        // Centrar el UserControl en el formulario padre
    //        notification.Left = (owner.ClientSize.Width - notification.Width) / 2;
    //        notification.Top = (owner.ClientSize.Height - notification.Height) / 2;

    //        // Evento del botón OK dentro de tu UserControl
    //        notification.OkButton.Click += (s, e) =>
    //        {
    //            owner.Controls.Remove(overlay);
    //            overlay.Dispose();
    //        };

    //        overlay.Controls.Add(notification);
    //        notification.BringToFront();
    //    }
    //}

    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(MetroForm owner, string message)
    //    {
    //        // 1️⃣ Crear overlay semi-transparente
    //        Panel overlay = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            BackColor = Color.FromArgb(128, 30, 9, 102),
    //        };

    //        owner.Controls.Add(overlay);
    //        overlay.BringToFront();
    //        overlay.Visible = true;
    //        overlay.Focus();

    //        // 2️⃣ Crear instancia de tu UserControl
    //        var notification = new MetroPrimaryButtoncs
    //        {
    //            TextMessage = message,
    //            BackColor = Color.White
    //        };

    //        // 🔹 Centrar en el formulario
    //        notification.Left = (owner.ClientSize.Width - notification.Width) / 2;
    //        notification.Top = (owner.ClientSize.Height - notification.Height) / 2;

    //        // 3️⃣ Agregarlo al overlay
    //        overlay.Controls.Add(notification);
    //        notification.BringToFront();
    //        notification.Visible = true;

    //        // 4️⃣ Evento del botón OK dentro de tu UserControl
    //        notification.OkButton.Click += (s, e) =>
    //        {
    //            owner.Controls.Remove(overlay);
    //            overlay.Dispose();
    //        };
    //    }
    //}

    //public static class MetroMessageHelper
    //{
    //    public static void ShowWithOverlay(MetroForm owner, string message)
    //    {
    //        Panel overlay = new Panel
    //        {
    //            Dock = DockStyle.Fill,
    //            BackColor = Color.FromArgb(128, 30, 9, 102),
    //            Visible = true
    //        };

    //        owner.Controls.Add(overlay);
    //        overlay.BringToFront();
    //        overlay.Focus();

    //        var notification = new MetroPrimaryButtoncs
    //        {
    //            TextMessage = message,
    //            Size = new Size(300, 150),
    //            BackColor = Color.White,
    //            Visible = true
    //        };

    //        notification.Left = (owner.ClientSize.Width - notification.Width) / 2;
    //        notification.Top = (owner.ClientSize.Height - notification.Height) / 2;

    //        // Para evitar múltiples suscripciones:
    //        notification.OkButton.Click -= (s, e) => { };
    //        notification.OkButton.Click += (s, e) =>
    //        {
    //            owner.Controls.Remove(overlay);
    //            overlay.Dispose();
    //        };

    //        overlay.Controls.Add(notification);
    //        notification.BringToFront();
    //    }
    //}

    public static class MetroMessageHelper
    {
        public static void ShowWithOverlay(MetroForm owner, string message)
        {
            // 🔹 Crear overlay semitransparente
            Panel overlay = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(128, 30, 9, 102), // 50% opacidad
            };

            // Agregar overlay al formulario
            owner.Controls.Add(overlay);
            overlay.BringToFront();

            // 🔹 Crear instancia de tu UserControl custom
            var notification = new MetroPrimaryButtoncs
            {
                TextMessage = message,
            };

            // 🔹 Centrar el control
            notification.Left = (owner.ClientSize.Width - notification.Width) / 2;
            notification.Top = (owner.ClientSize.Height - notification.Height) / 2;

            // 🔹 Evento de cierre con el botón OK del UserControl
            notification.OkButton.Click += (s, e) =>
            {
                owner.Controls.Remove(overlay);
                overlay.Dispose();
            };

            // Agregar notificación al overlay
            overlay.Controls.Add(notification);
            notification.BringToFront();
        }
    }


}
