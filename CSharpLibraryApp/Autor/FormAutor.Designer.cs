namespace CSharpLibraryApp.Autor
{
    partial class FormAutor
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
            this.labelNombre = new System.Windows.Forms.Label();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancelar = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(168, 72);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 19);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(233, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(213, 25);
            this.textBoxNombre.TabIndex = 2;
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(233, 131);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(213, 25);
            this.comboBoxPais.TabIndex = 3;
            // 
            // dateTimePickerFechaNacimiento
            // 
            this.dateTimePickerFechaNacimiento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.dateTimePickerFechaNacimiento.Location = new System.Drawing.Point(233, 100);
            this.dateTimePickerFechaNacimiento.Name = "dateTimePickerFechaNacimiento";
            this.dateTimePickerFechaNacimiento.Size = new System.Drawing.Size(213, 25);
            this.dateTimePickerFechaNacimiento.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.metroButtonGuardar);
            this.panel1.Controls.Add(this.metroButtonCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePickerFechaNacimiento);
            this.panel1.Controls.Add(this.comboBoxPais);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.labelNombre);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 335);
            this.panel1.TabIndex = 6;
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
            this.metroButtonGuardar.Click += new System.EventHandler(this.metroButtonGuardar_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(104, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "País de nacimiento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Autor";
            // 
            // FormAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.panel1);
            this.Name = "FormAutor";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.Text = "FormAutor";
            this.Load += new System.EventHandler(this.FormAutor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaNacimiento;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonCancelar;
    }
}