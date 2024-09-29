namespace PuntoDeVenta_Unidad3
{
    partial class Login
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
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BTN_Ingresar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(159, 81);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(196, 22);
            this.TXT_Usuario.TabIndex = 0;
            // 
            // TXT_Clave
            // 
            this.TXT_Clave.Location = new System.Drawing.Point(159, 170);
            this.TXT_Clave.Name = "TXT_Clave";
            this.TXT_Clave.Size = new System.Drawing.Size(196, 22);
            this.TXT_Clave.TabIndex = 1;
            this.TXT_Clave.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(221, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(204, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // BTN_Ingresar
            // 
            this.BTN_Ingresar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Ingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Ingresar.Location = new System.Drawing.Point(107, 226);
            this.BTN_Ingresar.Name = "BTN_Ingresar";
            this.BTN_Ingresar.Size = new System.Drawing.Size(132, 65);
            this.BTN_Ingresar.TabIndex = 4;
            this.BTN_Ingresar.Text = "Ingresar";
            this.BTN_Ingresar.UseVisualStyleBackColor = false;
            this.BTN_Ingresar.Click += new System.EventHandler(this.BTN_Ingresar_Click);
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cerrar.Location = new System.Drawing.Point(278, 226);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(132, 65);
            this.BTN_Cerrar.TabIndex = 5;
            this.BTN_Cerrar.Text = "Cerrar";
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(519, 335);
            this.ControlBox = false;
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Ingresar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_Clave);
            this.Controls.Add(this.TXT_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTN_Ingresar;
        private System.Windows.Forms.Button BTN_Cerrar;
    }
}

