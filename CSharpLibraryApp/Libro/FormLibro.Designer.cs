namespace CSharpLibraryApp.Libro
{
    partial class FormLibro
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
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.comboBoxEditorial = new System.Windows.Forms.ComboBox();
            this.textBoxSinopsis = new System.Windows.Forms.TextBox();
            this.textBoxAnioPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancelar = new MetroFramework.Controls.MetroButton();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(233, 248);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(213, 25);
            this.comboBoxGenero.TabIndex = 13;
            // 
            // comboBoxEditorial
            // 
            this.comboBoxEditorial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEditorial.FormattingEnabled = true;
            this.comboBoxEditorial.Location = new System.Drawing.Point(233, 217);
            this.comboBoxEditorial.Name = "comboBoxEditorial";
            this.comboBoxEditorial.Size = new System.Drawing.Size(213, 25);
            this.comboBoxEditorial.TabIndex = 11;
            // 
            // textBoxSinopsis
            // 
            this.textBoxSinopsis.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSinopsis.Location = new System.Drawing.Point(233, 162);
            this.textBoxSinopsis.Multiline = true;
            this.textBoxSinopsis.Name = "textBoxSinopsis";
            this.textBoxSinopsis.Size = new System.Drawing.Size(213, 49);
            this.textBoxSinopsis.TabIndex = 9;
            // 
            // textBoxAnioPublicacion
            // 
            this.textBoxAnioPublicacion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnioPublicacion.Location = new System.Drawing.Point(233, 131);
            this.textBoxAnioPublicacion.Name = "textBoxAnioPublicacion";
            this.textBoxAnioPublicacion.Size = new System.Drawing.Size(213, 25);
            this.textBoxAnioPublicacion.TabIndex = 6;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIsbn.Location = new System.Drawing.Point(233, 100);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(213, 25);
            this.textBoxIsbn.TabIndex = 5;
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTitulo.Location = new System.Drawing.Point(233, 69);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(213, 25);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBoxGenero);
            this.panel1.Controls.Add(this.metroButtonGuardar);
            this.panel1.Controls.Add(this.comboBoxEditorial);
            this.panel1.Controls.Add(this.metroButtonCancelar);
            this.panel1.Controls.Add(this.textBoxTitulo);
            this.panel1.Controls.Add(this.textBoxSinopsis);
            this.panel1.Controls.Add(this.textBoxIsbn);
            this.panel1.Controls.Add(this.textBoxAnioPublicacion);
            this.panel1.Controls.Add(this.labelTitulo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 335);
            this.panel1.TabIndex = 14;
            // 
            // metroButtonGuardar
            // 
            this.metroButtonGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonGuardar.ForeColor = System.Drawing.Color.White;
            this.metroButtonGuardar.Location = new System.Drawing.Point(233, 279);
            this.metroButtonGuardar.Name = "metroButtonGuardar";
            this.metroButtonGuardar.Size = new System.Drawing.Size(103, 25);
            this.metroButtonGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.metroButtonGuardar.TabIndex = 9;
            this.metroButtonGuardar.Text = "Guardar";
            this.metroButtonGuardar.UseCustomBackColor = true;
            this.metroButtonGuardar.UseCustomForeColor = true;
            this.metroButtonGuardar.UseSelectable = true;
            // 
            // metroButtonCancelar
            // 
            this.metroButtonCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.metroButtonCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroButtonCancelar.ForeColor = System.Drawing.Color.White;
            this.metroButtonCancelar.Location = new System.Drawing.Point(343, 279);
            this.metroButtonCancelar.Name = "metroButtonCancelar";
            this.metroButtonCancelar.Size = new System.Drawing.Size(103, 25);
            this.metroButtonCancelar.Style = MetroFramework.MetroColorStyle.Black;
            this.metroButtonCancelar.TabIndex = 8;
            this.metroButtonCancelar.Text = "Cancelar";
            this.metroButtonCancelar.UseCustomBackColor = true;
            this.metroButtonCancelar.UseCustomForeColor = true;
            this.metroButtonCancelar.UseSelectable = true;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelTitulo.ForeColor = System.Drawing.Color.White;
            this.labelTitulo.Location = new System.Drawing.Point(184, 72);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(43, 19);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(189, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 14;
            this.label2.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(102, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 19);
            this.label3.TabIndex = 15;
            this.label3.Text = "Año de publicación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 19);
            this.label4.TabIndex = 16;
            this.label4.Text = "Sinopsis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(169, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 17;
            this.label5.Text = "Editorial";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(173, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "Género";
            // 
            // FormLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.panel1);
            this.Name = "FormLibro";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.TextBox textBoxAnioPublicacion;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.TextBox textBoxSinopsis;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.ComboBox comboBoxEditorial;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonCancelar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}