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
            this.btn_cambiar_mensaje = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_lanzar_mensaje
            // 
            this.btn_lanzar_mensaje.Location = new System.Drawing.Point(89, 32);
            this.btn_lanzar_mensaje.Name = "btn_lanzar_mensaje";
            this.btn_lanzar_mensaje.Size = new System.Drawing.Size(104, 37);
            this.btn_lanzar_mensaje.TabIndex = 0;
            this.btn_lanzar_mensaje.Text = "Mostrar mensaje";
            this.btn_lanzar_mensaje.UseVisualStyleBackColor = true;
            this.btn_lanzar_mensaje.Click += new System.EventHandler(this.btn_lanzar_mensaje_Click);
            // 
            // btn_cambiar_mensaje
            // 
            this.btn_cambiar_mensaje.Location = new System.Drawing.Point(89, 101);
            this.btn_cambiar_mensaje.Name = "btn_cambiar_mensaje";
            this.btn_cambiar_mensaje.Size = new System.Drawing.Size(104, 37);
            this.btn_cambiar_mensaje.TabIndex = 1;
            this.btn_cambiar_mensaje.Text = "Cambiar mensaje";
            this.btn_cambiar_mensaje.UseVisualStyleBackColor = true;
            this.btn_cambiar_mensaje.Click += new System.EventHandler(this.btn_cambiar_mensaje_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 182);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(189, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nuevo mesaje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_cambiar_mensaje);
            this.Controls.Add(this.btn_lanzar_mensaje);
            this.Name = "Form1";
            this.Text = "Mensajes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_lanzar_mensaje;
        private System.Windows.Forms.Button btn_cambiar_mensaje;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

