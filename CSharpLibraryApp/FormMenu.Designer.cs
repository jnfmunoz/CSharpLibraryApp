namespace CSharpLibraryApp
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelLibroAutor = new System.Windows.Forms.Label();
            this.labelLibro = new System.Windows.Forms.Label();
            this.metroButtonLibro = new MetroFramework.Controls.MetroButton();
            this.labelGenero = new System.Windows.Forms.Label();
            this.metroButtonGenero = new MetroFramework.Controls.MetroButton();
            this.labelEditorial = new System.Windows.Forms.Label();
            this.metroButtonEditorial = new MetroFramework.Controls.MetroButton();
            this.labelAutor = new System.Windows.Forms.Label();
            this.metroButtonLibroAutor = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroButtonAutor = new MetroFramework.Controls.MetroButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.labelLibroAutor);
            this.panel1.Controls.Add(this.labelLibro);
            this.panel1.Controls.Add(this.metroButtonLibro);
            this.panel1.Controls.Add(this.labelGenero);
            this.panel1.Controls.Add(this.metroButtonGenero);
            this.panel1.Controls.Add(this.labelEditorial);
            this.panel1.Controls.Add(this.metroButtonEditorial);
            this.panel1.Controls.Add(this.labelAutor);
            this.panel1.Controls.Add(this.metroButtonLibroAutor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.metroButtonAutor);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 335);
            this.panel1.TabIndex = 0;
            // 
            // labelLibroAutor
            // 
            this.labelLibroAutor.AutoSize = true;
            this.labelLibroAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLibroAutor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibroAutor.ForeColor = System.Drawing.Color.White;
            this.labelLibroAutor.Location = new System.Drawing.Point(532, 271);
            this.labelLibroAutor.Name = "labelLibroAutor";
            this.labelLibroAutor.Size = new System.Drawing.Size(107, 17);
            this.labelLibroAutor.TabIndex = 13;
            this.labelLibroAutor.Text = "Libros - Autores";
            // 
            // labelLibro
            // 
            this.labelLibro.AutoSize = true;
            this.labelLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelLibro.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLibro.ForeColor = System.Drawing.Color.White;
            this.labelLibro.Location = new System.Drawing.Point(397, 271);
            this.labelLibro.Name = "labelLibro";
            this.labelLibro.Size = new System.Drawing.Size(46, 17);
            this.labelLibro.TabIndex = 12;
            this.labelLibro.Text = "Libros";
            // 
            // metroButtonLibro
            // 
            this.metroButtonLibro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonLibro.BackgroundImage")));
            this.metroButtonLibro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonLibro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonLibro.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLibro.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonLibro.Location = new System.Drawing.Point(236, 187);
            this.metroButtonLibro.Name = "metroButtonLibro";
            this.metroButtonLibro.Size = new System.Drawing.Size(216, 113);
            this.metroButtonLibro.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonLibro.TabIndex = 3;
            this.metroButtonLibro.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonLibro.UseCustomBackColor = true;
            this.metroButtonLibro.UseSelectable = true;
            this.metroButtonLibro.Click += new System.EventHandler(this.metroButtonLibro_Click);
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGenero.ForeColor = System.Drawing.Color.White;
            this.labelGenero.Location = new System.Drawing.Point(163, 271);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(58, 17);
            this.labelGenero.TabIndex = 10;
            this.labelGenero.Text = "Géneros";
            // 
            // metroButtonGenero
            // 
            this.metroButtonGenero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonGenero.BackgroundImage")));
            this.metroButtonGenero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonGenero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonGenero.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonGenero.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonGenero.Location = new System.Drawing.Point(14, 187);
            this.metroButtonGenero.Name = "metroButtonGenero";
            this.metroButtonGenero.Size = new System.Drawing.Size(216, 113);
            this.metroButtonGenero.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonGenero.TabIndex = 2;
            this.metroButtonGenero.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonGenero.UseCustomBackColor = true;
            this.metroButtonGenero.UseSelectable = true;
            this.metroButtonGenero.Click += new System.EventHandler(this.metroButtonGenero_Click);
            // 
            // labelEditorial
            // 
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelEditorial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditorial.ForeColor = System.Drawing.Color.White;
            this.labelEditorial.Location = new System.Drawing.Point(370, 153);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(73, 17);
            this.labelEditorial.TabIndex = 8;
            this.labelEditorial.Text = "Editoriales";
            // 
            // metroButtonEditorial
            // 
            this.metroButtonEditorial.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonEditorial.BackgroundImage")));
            this.metroButtonEditorial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonEditorial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonEditorial.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonEditorial.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonEditorial.Location = new System.Drawing.Point(236, 68);
            this.metroButtonEditorial.Name = "metroButtonEditorial";
            this.metroButtonEditorial.Size = new System.Drawing.Size(216, 113);
            this.metroButtonEditorial.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonEditorial.TabIndex = 1;
            this.metroButtonEditorial.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonEditorial.UseCustomBackColor = true;
            this.metroButtonEditorial.UseSelectable = true;
            this.metroButtonEditorial.Click += new System.EventHandler(this.metroButtonEditorial_Click);
            // 
            // labelAutor
            // 
            this.labelAutor.AutoSize = true;
            this.labelAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAutor.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAutor.ForeColor = System.Drawing.Color.White;
            this.labelAutor.Location = new System.Drawing.Point(165, 153);
            this.labelAutor.Name = "labelAutor";
            this.labelAutor.Size = new System.Drawing.Size(56, 17);
            this.labelAutor.TabIndex = 6;
            this.labelAutor.Text = "Autores";
            // 
            // metroButtonLibroAutor
            // 
            this.metroButtonLibroAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonLibroAutor.BackgroundImage")));
            this.metroButtonLibroAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonLibroAutor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonLibroAutor.ForeColor = System.Drawing.Color.White;
            this.metroButtonLibroAutor.Location = new System.Drawing.Point(458, 68);
            this.metroButtonLibroAutor.Name = "metroButtonLibroAutor";
            this.metroButtonLibroAutor.Size = new System.Drawing.Size(190, 232);
            this.metroButtonLibroAutor.TabIndex = 4;
            this.metroButtonLibroAutor.UseSelectable = true;
            this.metroButtonLibroAutor.Click += new System.EventHandler(this.metroButtonLibroAutor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menú";
            // 
            // metroButtonAutor
            // 
            this.metroButtonAutor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("metroButtonAutor.BackgroundImage")));
            this.metroButtonAutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonAutor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonAutor.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.metroButtonAutor.ForeColor = System.Drawing.Color.Transparent;
            this.metroButtonAutor.Location = new System.Drawing.Point(14, 68);
            this.metroButtonAutor.Name = "metroButtonAutor";
            this.metroButtonAutor.Size = new System.Drawing.Size(216, 113);
            this.metroButtonAutor.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonAutor.TabIndex = 0;
            this.metroButtonAutor.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.metroButtonAutor.UseCustomBackColor = true;
            this.metroButtonAutor.UseSelectable = true;
            this.metroButtonAutor.Click += new System.EventHandler(this.metroButtonAutor_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.panel1);
            this.Name = "FormMenu";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonLibroAutor;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton metroButtonAutor;
        private System.Windows.Forms.Label labelAutor;
        private System.Windows.Forms.Label labelLibro;
        private MetroFramework.Controls.MetroButton metroButtonLibro;
        private System.Windows.Forms.Label labelGenero;
        private MetroFramework.Controls.MetroButton metroButtonGenero;
        private System.Windows.Forms.Label labelEditorial;
        private MetroFramework.Controls.MetroButton metroButtonEditorial;
        private System.Windows.Forms.Label labelLibroAutor;
    }
}