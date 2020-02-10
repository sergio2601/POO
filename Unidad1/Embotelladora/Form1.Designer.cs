namespace Embotelladora
{
    partial class frmembotelladora
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNivelLlenado = new System.Windows.Forms.Label();
            this.txtniveldellenado = new System.Windows.Forms.TextBox();
            this.btnverificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNivelLlenado
            // 
            this.lblNivelLlenado.AutoSize = true;
            this.lblNivelLlenado.Location = new System.Drawing.Point(30, 48);
            this.lblNivelLlenado.Name = "lblNivelLlenado";
            this.lblNivelLlenado.Size = new System.Drawing.Size(119, 13);
            this.lblNivelLlenado.TabIndex = 0;
            this.lblNivelLlenado.Text = "Ingrese nivel de llenado";
            // 
            // txtniveldellenado
            // 
            this.txtniveldellenado.Location = new System.Drawing.Point(172, 41);
            this.txtniveldellenado.Name = "txtniveldellenado";
            this.txtniveldellenado.Size = new System.Drawing.Size(100, 20);
            this.txtniveldellenado.TabIndex = 1;
            this.txtniveldellenado.TextChanged += new System.EventHandler(this.txtniveldellenado_TextChanged);
            // 
            // btnverificar
            // 
            this.btnverificar.Location = new System.Drawing.Point(172, 86);
            this.btnverificar.Name = "btnverificar";
            this.btnverificar.Size = new System.Drawing.Size(75, 23);
            this.btnverificar.TabIndex = 2;
            this.btnverificar.Text = "verificar";
            this.btnverificar.UseVisualStyleBackColor = true;
            this.btnverificar.Click += new System.EventHandler(this.btnverificar_Click);
            // 
            // frmembotelladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnverificar);
            this.Controls.Add(this.txtniveldellenado);
            this.Controls.Add(this.lblNivelLlenado);
            this.Name = "frmembotelladora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNivelLlenado;
        private System.Windows.Forms.TextBox txtniveldellenado;
        private System.Windows.Forms.Button btnverificar;
    }
}

