namespace CSharpLibraryApp.Libro
{
    partial class FormLibros
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLibros));
            this.dataGridViewLibro = new System.Windows.Forms.DataGridView();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAtras = new System.Windows.Forms.Label();
            this.labelEliminar = new System.Windows.Forms.Label();
            this.labelEditar = new System.Windows.Forms.Label();
            this.labelAgregar = new System.Windows.Forms.Label();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.metroButtonEliminar = new MetroFramework.Controls.MetroButton();
            this.metroButtonAtras = new MetroFramework.Controls.MetroButton();
            this.metroButtonEditar = new MetroFramework.Controls.MetroButton();
            this.metroButtonAgregar = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibro)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLibro
            // 
            this.dataGridViewLibro.AllowUserToAddRows = false;
            this.dataGridViewLibro.AllowUserToDeleteRows = false;
            this.dataGridViewLibro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLibro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewLibro.Location = new System.Drawing.Point(14, 164);
            this.dataGridViewLibro.MultiSelect = false;
            this.dataGridViewLibro.Name = "dataGridViewLibro";
            this.dataGridViewLibro.ReadOnly = true;
            this.dataGridViewLibro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewLibro.Size = new System.Drawing.Size(635, 160);
            this.dataGridViewLibro.TabIndex = 0;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(277, 67);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(118, 20);
            this.textBoxBuscar.TabIndex = 0;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.dataGridViewLibro);
            this.panel1.Controls.Add(this.labelAtras);
            this.panel1.Controls.Add(this.labelEliminar);
            this.panel1.Controls.Add(this.labelEditar);
            this.panel1.Controls.Add(this.labelAgregar);
            this.panel1.Controls.Add(this.labelBuscar);
            this.panel1.Controls.Add(this.metroButtonEliminar);
            this.panel1.Controls.Add(this.metroButtonAtras);
            this.panel1.Controls.Add(this.metroButtonEditar);
            this.panel1.Controls.Add(this.metroButtonAgregar);
            this.panel1.Controls.Add(this.textBoxBuscar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 335);
            this.panel1.TabIndex = 29;
            // 
            // labelAtras
            // 
            this.labelAtras.AutoSize = true;
            this.labelAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAtras.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelAtras.ForeColor = System.Drawing.Color.White;
            this.labelAtras.Location = new System.Drawing.Point(525, 141);
            this.labelAtras.Name = "labelAtras";
            this.labelAtras.Size = new System.Drawing.Size(34, 13);
            this.labelAtras.TabIndex = 12;
            this.labelAtras.Text = "Atrás";
            // 
            // labelEliminar
            // 
            this.labelEliminar.AutoSize = true;
            this.labelEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEliminar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelEliminar.ForeColor = System.Drawing.Color.White;
            this.labelEliminar.Location = new System.Drawing.Point(389, 141);
            this.labelEliminar.Name = "labelEliminar";
            this.labelEliminar.Size = new System.Drawing.Size(49, 13);
            this.labelEliminar.TabIndex = 11;
            this.labelEliminar.Text = "Eliminar";
            // 
            // labelEditar
            // 
            this.labelEditar.AutoSize = true;
            this.labelEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEditar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelEditar.ForeColor = System.Drawing.Color.White;
            this.labelEditar.Location = new System.Drawing.Point(290, 141);
            this.labelEditar.Name = "labelEditar";
            this.labelEditar.Size = new System.Drawing.Size(37, 13);
            this.labelEditar.TabIndex = 10;
            this.labelEditar.Text = "Editar";
            // 
            // labelAgregar
            // 
            this.labelAgregar.AutoSize = true;
            this.labelAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.labelAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAgregar.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.labelAgregar.ForeColor = System.Drawing.Color.White;
            this.labelAgregar.Location = new System.Drawing.Point(157, 141);
            this.labelAgregar.Name = "labelAgregar";
            this.labelAgregar.Size = new System.Drawing.Size(49, 13);
            this.labelAgregar.TabIndex = 9;
            this.labelAgregar.Text = "Agregar";
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBuscar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBuscar.ForeColor = System.Drawing.Color.White;
            this.labelBuscar.Location = new System.Drawing.Point(223, 67);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(48, 17);
            this.labelBuscar.TabIndex = 8;
            this.labelBuscar.Text = "Buscar";
            // 
            // metroButtonEliminar
            // 
            this.metroButtonEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonEliminar.BackgroundImage")));
            this.metroButtonEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonEliminar.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonEliminar.Location = new System.Drawing.Point(337, 98);
            this.metroButtonEliminar.Name = "metroButtonEliminar";
            this.metroButtonEliminar.Size = new System.Drawing.Size(105, 60);
            this.metroButtonEliminar.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonEliminar.TabIndex = 7;
            this.metroButtonEliminar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonEliminar.UseCustomBackColor = true;
            this.metroButtonEliminar.UseSelectable = true;
            this.metroButtonEliminar.Click += new System.EventHandler(this.metroButtonEliminar_Click);
            // 
            // metroButtonAtras
            // 
            this.metroButtonAtras.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonAtras.BackgroundImage")));
            this.metroButtonAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonAtras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonAtras.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAtras.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonAtras.Location = new System.Drawing.Point(448, 98);
            this.metroButtonAtras.Name = "metroButtonAtras";
            this.metroButtonAtras.Size = new System.Drawing.Size(115, 60);
            this.metroButtonAtras.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonAtras.TabIndex = 6;
            this.metroButtonAtras.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonAtras.UseCustomBackColor = true;
            this.metroButtonAtras.UseSelectable = true;
            // 
            // metroButtonEditar
            // 
            this.metroButtonEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonEditar.BackgroundImage")));
            this.metroButtonEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonEditar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonEditar.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonEditar.Location = new System.Drawing.Point(216, 98);
            this.metroButtonEditar.Name = "metroButtonEditar";
            this.metroButtonEditar.Size = new System.Drawing.Size(115, 60);
            this.metroButtonEditar.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonEditar.TabIndex = 5;
            this.metroButtonEditar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonEditar.UseCustomBackColor = true;
            this.metroButtonEditar.UseSelectable = true;
            this.metroButtonEditar.Click += new System.EventHandler(this.metroButtonEditar_Click);
            // 
            // metroButtonAgregar
            // 
            this.metroButtonAgregar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonAgregar.BackgroundImage")));
            this.metroButtonAgregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAgregar.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonAgregar.Location = new System.Drawing.Point(95, 98);
            this.metroButtonAgregar.Name = "metroButtonAgregar";
            this.metroButtonAgregar.Size = new System.Drawing.Size(115, 60);
            this.metroButtonAgregar.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonAgregar.TabIndex = 4;
            this.metroButtonAgregar.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonAgregar.UseCustomBackColor = true;
            this.metroButtonAgregar.UseSelectable = true;
            this.metroButtonAgregar.Click += new System.EventHandler(this.metroButtonAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libros";
            // 
            // FormLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.panel1);
            this.Name = "FormLibros";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FormLibros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLibro)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewLibro;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAtras;
        private System.Windows.Forms.Label labelEliminar;
        private System.Windows.Forms.Label labelEditar;
        private System.Windows.Forms.Label labelAgregar;
        private System.Windows.Forms.Label labelBuscar;
        private MetroFramework.Controls.MetroButton metroButtonEliminar;
        private MetroFramework.Controls.MetroButton metroButtonAtras;
        private MetroFramework.Controls.MetroButton metroButtonEditar;
        private MetroFramework.Controls.MetroButton metroButtonAgregar;
        private System.Windows.Forms.Label label1;
    }
}