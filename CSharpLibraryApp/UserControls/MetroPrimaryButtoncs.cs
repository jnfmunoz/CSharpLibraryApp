using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpLibraryApp.UserControls
{
    //public partial class MetroPrimaryButtoncs : UserControl
    //{
    //    public MetroPrimaryButtoncs()
    //    {
    //        InitializeComponent();
    //        this.Visible = true;
    //        this.Size = new Size(662, 230);
    //    }

    //    [Category("Custom")]
    //    public string TextMessage
    //    {
    //        get => labelMensaje.Text;
    //        set => labelMensaje.Text = value;
    //    }

    //    public Button OkButton => MetroButtonOk;

    //}

    //public partial class MetroPrimaryButtoncs : UserControl
    //{
    //    public MetroPrimaryButtoncs()
    //    {
    //        InitializeComponent();
    //        this.Size = new Size(300, 150);  // tamaño fijo
    //        this.Visible = true;
    //        labelMensaje.ForeColor = Color.Black; // color visible
    //                                              // Asegúrate que labelMensaje tenga AutoSize = true en diseñador
    //    }

    //    [Category("Custom")]
    //    public string TextMessage
    //    {
    //        get => labelMensaje.Text;
    //        set => labelMensaje.Text = value;
    //    }

    //    public Button OkButton => MetroButtonOk;
    //}

    public partial class MetroPrimaryButtoncs : UserControl
    {
        public MetroPrimaryButtoncs()
        {
            InitializeComponent();
            ApplyCustomStyle();
        }

        // 🔹 Propiedad para asignar el mensaje dinámico
        [Category("Custom")]
        public string TextMessage
        {
            get => labelMensaje.Text;
            set => labelMensaje.Text = value;
        }

        // 🔹 Propiedad para acceder al botón OK
        public Button OkButton => MetroButtonOk;

        // 🔹 Aplicar estilo visual
        private void ApplyCustomStyle()
        {
            // Estilo del UserControl
            this.BackColor = Color.White;
            this.BorderStyle = BorderStyle.FixedSingle;

            // Estilo del label
            labelMensaje.ForeColor = Color.Black;
            labelMensaje.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMensaje.TextAlign = ContentAlignment.MiddleCenter;

            // Estilo del botón
            MetroButtonOk.Text = "OK";
            MetroButtonOk.BackColor = Color.FromArgb(30, 9, 102);  // Tu color principal
            MetroButtonOk.ForeColor = Color.White;                 // Texto blanco
            MetroButtonOk.FlatStyle = FlatStyle.Flat;
            MetroButtonOk.FlatAppearance.BorderColor = Color.White;
            MetroButtonOk.FlatAppearance.BorderSize = 2;
            MetroButtonOk.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
        }
    }

}
