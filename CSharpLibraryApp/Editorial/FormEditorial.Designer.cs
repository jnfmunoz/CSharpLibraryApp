namespace CSharpLibraryApp.Editorial
{
    partial class FormEditorial
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
            this.comboBoxPais = new System.Windows.Forms.ComboBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroButtonGuardar = new MetroFramework.Controls.MetroButton();
            this.metroButtonCancelar = new MetroFramework.Controls.MetroButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxPais
            // 
            this.comboBoxPais.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPais.FormattingEnabled = true;
            this.comboBoxPais.Location = new System.Drawing.Point(233, 100);
            this.comboBoxPais.Name = "comboBoxPais";
            this.comboBoxPais.Size = new System.Drawing.Size(211, 25);
            this.comboBoxPais.TabIndex = 3;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(233, 69);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(211, 25);
            this.textBoxNombre.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.panel1.Controls.Add(this.comboBoxPais);
            this.panel1.Controls.Add(this.metroButtonGuardar);
            this.panel1.Controls.Add(this.textBoxNombre);
            this.panel1.Controls.Add(this.metroButtonCancelar);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 335);
            this.panel1.TabIndex = 7;
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
            this.metroButtonCancelar.Location = new System.Drawing.Point(342, 279);
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
            this.label3.Location = new System.Drawing.Point(194, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 19);
            this.label3.TabIndex = 6;
            this.label3.Text = "País";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(169, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 65);
            this.label4.TabIndex = 1;
            this.label4.Text = "Editorial";
            // 
            // FormEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 360);
            this.Controls.Add(this.panel1);
            this.Name = "FormEditorial";
            this.Style = MetroFramework.MetroColorStyle.White;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxPais;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton metroButtonGuardar;
        private MetroFramework.Controls.MetroButton metroButtonCancelar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
    }
}