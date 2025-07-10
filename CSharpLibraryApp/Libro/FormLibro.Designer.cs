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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxAnioPublicacion = new System.Windows.Forms.TextBox();
            this.textBoxIsbn = new System.Windows.Forms.TextBox();
            this.labelIsbn = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.labelAnioPublicacion = new System.Windows.Forms.Label();
            this.labelSinopsis = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelEditorial = new System.Windows.Forms.Label();
            this.comboBoxEditorial = new System.Windows.Forms.ComboBox();
            this.labelGenero = new System.Windows.Forms.Label();
            this.comboBoxGenero = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 67);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editorial";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxGenero);
            this.groupBox2.Controls.Add(this.labelGenero);
            this.groupBox2.Controls.Add(this.comboBoxEditorial);
            this.groupBox2.Controls.Add(this.labelEditorial);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.labelSinopsis);
            this.groupBox2.Controls.Add(this.labelAnioPublicacion);
            this.groupBox2.Controls.Add(this.textBoxAnioPublicacion);
            this.groupBox2.Controls.Add(this.textBoxIsbn);
            this.groupBox2.Controls.Add(this.labelIsbn);
            this.groupBox2.Controls.Add(this.textBoxTitulo);
            this.groupBox2.Controls.Add(this.labelTitulo);
            this.groupBox2.Location = new System.Drawing.Point(12, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 261);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // textBoxAnioPublicacion
            // 
            this.textBoxAnioPublicacion.Location = new System.Drawing.Point(332, 73);
            this.textBoxAnioPublicacion.Name = "textBoxAnioPublicacion";
            this.textBoxAnioPublicacion.Size = new System.Drawing.Size(100, 20);
            this.textBoxAnioPublicacion.TabIndex = 6;
            // 
            // textBoxIsbn
            // 
            this.textBoxIsbn.Location = new System.Drawing.Point(332, 46);
            this.textBoxIsbn.Name = "textBoxIsbn";
            this.textBoxIsbn.Size = new System.Drawing.Size(100, 20);
            this.textBoxIsbn.TabIndex = 5;
            // 
            // labelIsbn
            // 
            this.labelIsbn.AutoSize = true;
            this.labelIsbn.Location = new System.Drawing.Point(285, 53);
            this.labelIsbn.Name = "labelIsbn";
            this.labelIsbn.Size = new System.Drawing.Size(32, 13);
            this.labelIsbn.TabIndex = 4;
            this.labelIsbn.Text = "ISBN";
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(332, 19);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Location = new System.Drawing.Point(282, 19);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(35, 13);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Título";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonGuardar);
            this.groupBox3.Controls.Add(this.buttonCancelar);
            this.groupBox3.Controls.Add(this.buttonLimpiar);
            this.groupBox3.Location = new System.Drawing.Point(12, 352);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 86);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(251, 19);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 3;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(413, 19);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(332, 19);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 1;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // labelAnioPublicacion
            // 
            this.labelAnioPublicacion.AutoSize = true;
            this.labelAnioPublicacion.Location = new System.Drawing.Point(227, 80);
            this.labelAnioPublicacion.Name = "labelAnioPublicacion";
            this.labelAnioPublicacion.Size = new System.Drawing.Size(99, 13);
            this.labelAnioPublicacion.TabIndex = 7;
            this.labelAnioPublicacion.Text = "Año de Publicación";
            // 
            // labelSinopsis
            // 
            this.labelSinopsis.AutoSize = true;
            this.labelSinopsis.Location = new System.Drawing.Point(271, 106);
            this.labelSinopsis.Name = "labelSinopsis";
            this.labelSinopsis.Size = new System.Drawing.Size(46, 13);
            this.labelSinopsis.TabIndex = 8;
            this.labelSinopsis.Text = "Sinopsis";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(332, 103);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 49);
            this.textBox1.TabIndex = 9;
            // 
            // labelEditorial
            // 
            this.labelEditorial.AutoSize = true;
            this.labelEditorial.Location = new System.Drawing.Point(281, 162);
            this.labelEditorial.Name = "labelEditorial";
            this.labelEditorial.Size = new System.Drawing.Size(44, 13);
            this.labelEditorial.TabIndex = 10;
            this.labelEditorial.Text = "Editorial";
            // 
            // comboBoxEditorial
            // 
            this.comboBoxEditorial.FormattingEnabled = true;
            this.comboBoxEditorial.Location = new System.Drawing.Point(332, 158);
            this.comboBoxEditorial.Name = "comboBoxEditorial";
            this.comboBoxEditorial.Size = new System.Drawing.Size(121, 21);
            this.comboBoxEditorial.TabIndex = 11;
            // 
            // labelGenero
            // 
            this.labelGenero.AutoSize = true;
            this.labelGenero.Location = new System.Drawing.Point(285, 194);
            this.labelGenero.Name = "labelGenero";
            this.labelGenero.Size = new System.Drawing.Size(42, 13);
            this.labelGenero.TabIndex = 12;
            this.labelGenero.Text = "Género";
            // 
            // comboBoxGenero
            // 
            this.comboBoxGenero.FormattingEnabled = true;
            this.comboBoxGenero.Location = new System.Drawing.Point(332, 186);
            this.comboBoxGenero.Name = "comboBoxGenero";
            this.comboBoxGenero.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGenero.TabIndex = 13;
            // 
            // FormLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "FormLibro";
            this.Text = "FormLibro";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.TextBox textBoxAnioPublicacion;
        private System.Windows.Forms.TextBox textBoxIsbn;
        private System.Windows.Forms.Label labelIsbn;
        private System.Windows.Forms.Label labelAnioPublicacion;
        private System.Windows.Forms.Label labelSinopsis;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelEditorial;
        private System.Windows.Forms.ComboBox comboBoxGenero;
        private System.Windows.Forms.Label labelGenero;
        private System.Windows.Forms.ComboBox comboBoxEditorial;
    }
}