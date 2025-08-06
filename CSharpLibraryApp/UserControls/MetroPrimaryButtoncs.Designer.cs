namespace CSharpLibraryApp.UserControls
{
    partial class MetroPrimaryButtoncs
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.MetroButtonOk = new MetroFramework.Controls.MetroButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelMensaje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MetroButtonOk
            // 
            this.MetroButtonOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.MetroButtonOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MetroButtonOk.ForeColor = System.Drawing.Color.White;
            this.MetroButtonOk.Location = new System.Drawing.Point(560, 185);
            this.MetroButtonOk.Name = "MetroButtonOk";
            this.MetroButtonOk.Size = new System.Drawing.Size(75, 23);
            this.MetroButtonOk.TabIndex = 0;
            this.MetroButtonOk.Text = "Ok";
            this.MetroButtonOk.UseCustomBackColor = true;
            this.MetroButtonOk.UseCustomForeColor = true;
            this.MetroButtonOk.UseSelectable = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelMensaje);
            this.panel1.Controls.Add(this.MetroButtonOk);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 230);
            this.panel1.TabIndex = 2;
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMensaje.ForeColor = System.Drawing.Color.White;
            this.labelMensaje.Location = new System.Drawing.Point(20, 20);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(0, 17);
            this.labelMensaje.TabIndex = 1;
            // 
            // MetroPrimaryButtoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.panel1);
            this.Name = "MetroPrimaryButtoncs";
            this.Size = new System.Drawing.Size(662, 230);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton MetroButtonOk;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelMensaje;
    }
}
