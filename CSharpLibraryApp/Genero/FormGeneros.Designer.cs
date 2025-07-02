namespace CSharpLibraryApp.Genero
{
    partial class FormGeneros
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
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonEliminarGenero = new System.Windows.Forms.Button();
            this.buttonEditarGenero = new System.Windows.Forms.Button();
            this.buttonAgregarGenero = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewGenero = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 58);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Géneros";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxBuscar);
            this.groupBox2.Location = new System.Drawing.Point(12, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar";
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(314, 19);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(118, 20);
            this.textBoxBuscar.TabIndex = 0;
            this.textBoxBuscar.TextChanged += new System.EventHandler(this.textBoxBuscar_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonAtras);
            this.groupBox3.Controls.Add(this.buttonEliminarGenero);
            this.groupBox3.Controls.Add(this.buttonEditarGenero);
            this.groupBox3.Controls.Add(this.buttonAgregarGenero);
            this.groupBox3.Location = new System.Drawing.Point(12, 138);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 62);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            // 
            // buttonAtras
            // 
            this.buttonAtras.Location = new System.Drawing.Point(453, 20);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 3;
            this.buttonAtras.Text = "Atrás";
            this.buttonAtras.UseVisualStyleBackColor = true;
            // 
            // buttonEliminarGenero
            // 
            this.buttonEliminarGenero.Location = new System.Drawing.Point(372, 19);
            this.buttonEliminarGenero.Name = "buttonEliminarGenero";
            this.buttonEliminarGenero.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminarGenero.TabIndex = 2;
            this.buttonEliminarGenero.Text = "Eliminar";
            this.buttonEliminarGenero.UseVisualStyleBackColor = true;
            this.buttonEliminarGenero.Click += new System.EventHandler(this.buttonEliminarGenero_Click);
            // 
            // buttonEditarGenero
            // 
            this.buttonEditarGenero.Location = new System.Drawing.Point(291, 20);
            this.buttonEditarGenero.Name = "buttonEditarGenero";
            this.buttonEditarGenero.Size = new System.Drawing.Size(75, 23);
            this.buttonEditarGenero.TabIndex = 1;
            this.buttonEditarGenero.Text = "Editar";
            this.buttonEditarGenero.UseVisualStyleBackColor = true;
            // 
            // buttonAgregarGenero
            // 
            this.buttonAgregarGenero.Location = new System.Drawing.Point(210, 20);
            this.buttonAgregarGenero.Name = "buttonAgregarGenero";
            this.buttonAgregarGenero.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarGenero.TabIndex = 0;
            this.buttonAgregarGenero.Text = "Agregar";
            this.buttonAgregarGenero.UseVisualStyleBackColor = true;
            this.buttonAgregarGenero.Click += new System.EventHandler(this.buttonAgregarGenero_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewGenero);
            this.groupBox4.Location = new System.Drawing.Point(12, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 237);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // dataGridViewGenero
            // 
            this.dataGridViewGenero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGenero.Location = new System.Drawing.Point(6, 9);
            this.dataGridViewGenero.MultiSelect = false;
            this.dataGridViewGenero.Name = "dataGridViewGenero";
            this.dataGridViewGenero.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewGenero.Size = new System.Drawing.Size(764, 222);
            this.dataGridViewGenero.TabIndex = 0;
            // 
            // FormGeneros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Name = "FormGeneros";
            this.Text = "FormGeneros";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGenero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonEliminarGenero;
        private System.Windows.Forms.Button buttonEditarGenero;
        private System.Windows.Forms.Button buttonAgregarGenero;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridViewGenero;
    }
}