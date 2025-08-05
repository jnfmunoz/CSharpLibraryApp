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
            this.Ok = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.Ok.ForeColor = System.Drawing.Color.White;
            this.Ok.Location = new System.Drawing.Point(559, 185);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseCustomBackColor = true;
            this.Ok.UseCustomForeColor = true;
            this.Ok.UseSelectable = true;
            // 
            // MetroPrimaryButtoncs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(9)))), ((int)(((byte)(102)))));
            this.Controls.Add(this.Ok);
            this.Name = "MetroPrimaryButtoncs";
            this.Size = new System.Drawing.Size(662, 230);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton Ok;
    }
}
