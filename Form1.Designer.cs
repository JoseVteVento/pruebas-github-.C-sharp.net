namespace Pruebas_github
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_lanzar_mensaje = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_lanzar_mensaje
            // 
            this.btn_lanzar_mensaje.Location = new System.Drawing.Point(91, 103);
            this.btn_lanzar_mensaje.Name = "btn_lanzar_mensaje";
            this.btn_lanzar_mensaje.Size = new System.Drawing.Size(104, 37);
            this.btn_lanzar_mensaje.TabIndex = 0;
            this.btn_lanzar_mensaje.Text = "Mostrar mensaje";
            this.btn_lanzar_mensaje.UseVisualStyleBackColor = true;
            this.btn_lanzar_mensaje.Click += new System.EventHandler(this.btn_lanzar_mensaje_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_lanzar_mensaje);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_lanzar_mensaje;
    }
}

