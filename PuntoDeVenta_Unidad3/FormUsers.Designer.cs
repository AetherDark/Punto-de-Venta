namespace PuntoDeVenta_Unidad3
{
    partial class FormUsers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.TXT_Nombre = new System.Windows.Forms.TextBox();
            this.TXT_Apellido = new System.Windows.Forms.TextBox();
            this.TXT_Usuario = new System.Windows.Forms.TextBox();
            this.TXT_Clave = new System.Windows.Forms.TextBox();
            this.BTN_NuevoUsuario = new System.Windows.Forms.Button();
            this.BTN_ModificarUsuario = new System.Windows.Forms.Button();
            this.BTN_EliminarUsuario = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BTN_Limpiar = new System.Windows.Forms.Button();
            this.TXT_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.TXT_DNI = new System.Windows.Forms.MaskedTextBox();
            this.errorProviderNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderClave = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClave)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(22, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // TXT_Nombre
            // 
            this.TXT_Nombre.Location = new System.Drawing.Point(60, 566);
            this.TXT_Nombre.Name = "TXT_Nombre";
            this.TXT_Nombre.Size = new System.Drawing.Size(155, 22);
            this.TXT_Nombre.TabIndex = 1;
            // 
            // TXT_Apellido
            // 
            this.TXT_Apellido.Location = new System.Drawing.Point(247, 566);
            this.TXT_Apellido.Name = "TXT_Apellido";
            this.TXT_Apellido.Size = new System.Drawing.Size(151, 22);
            this.TXT_Apellido.TabIndex = 2;
            // 
            // TXT_Usuario
            // 
            this.TXT_Usuario.Location = new System.Drawing.Point(824, 565);
            this.TXT_Usuario.Name = "TXT_Usuario";
            this.TXT_Usuario.Size = new System.Drawing.Size(141, 22);
            this.TXT_Usuario.TabIndex = 5;
            // 
            // TXT_Clave
            // 
            this.TXT_Clave.Location = new System.Drawing.Point(996, 565);
            this.TXT_Clave.Name = "TXT_Clave";
            this.TXT_Clave.Size = new System.Drawing.Size(143, 22);
            this.TXT_Clave.TabIndex = 6;
            // 
            // BTN_NuevoUsuario
            // 
            this.BTN_NuevoUsuario.BackColor = System.Drawing.Color.Gold;
            this.BTN_NuevoUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_NuevoUsuario.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NuevoUsuario.Location = new System.Drawing.Point(22, 616);
            this.BTN_NuevoUsuario.Name = "BTN_NuevoUsuario";
            this.BTN_NuevoUsuario.Size = new System.Drawing.Size(141, 61);
            this.BTN_NuevoUsuario.TabIndex = 7;
            this.BTN_NuevoUsuario.Text = "Nuevo Usuario";
            this.BTN_NuevoUsuario.UseVisualStyleBackColor = false;
            this.BTN_NuevoUsuario.Click += new System.EventHandler(this.BTN_NuevoUsuario_Click);
            // 
            // BTN_ModificarUsuario
            // 
            this.BTN_ModificarUsuario.BackColor = System.Drawing.Color.Gold;
            this.BTN_ModificarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_ModificarUsuario.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_ModificarUsuario.Location = new System.Drawing.Point(195, 614);
            this.BTN_ModificarUsuario.Name = "BTN_ModificarUsuario";
            this.BTN_ModificarUsuario.Size = new System.Drawing.Size(141, 62);
            this.BTN_ModificarUsuario.TabIndex = 8;
            this.BTN_ModificarUsuario.Text = "Modificar Usuario";
            this.BTN_ModificarUsuario.UseVisualStyleBackColor = false;
            this.BTN_ModificarUsuario.Click += new System.EventHandler(this.BTN_ModificarUsuario_Click);
            // 
            // BTN_EliminarUsuario
            // 
            this.BTN_EliminarUsuario.BackColor = System.Drawing.Color.Gold;
            this.BTN_EliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_EliminarUsuario.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_EliminarUsuario.Location = new System.Drawing.Point(379, 613);
            this.BTN_EliminarUsuario.Name = "BTN_EliminarUsuario";
            this.BTN_EliminarUsuario.Size = new System.Drawing.Size(141, 65);
            this.BTN_EliminarUsuario.TabIndex = 9;
            this.BTN_EliminarUsuario.Text = "Eliminar Usuario";
            this.BTN_EliminarUsuario.UseVisualStyleBackColor = false;
            this.BTN_EliminarUsuario.Click += new System.EventHandler(this.BTN_EliminarUsuario_Click);
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cerrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cerrar.Location = new System.Drawing.Point(1010, 623);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(141, 65);
            this.BTN_Cerrar.TabIndex = 10;
            this.BTN_Cerrar.Text = "Cerrar";
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 540);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(243, 540);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(425, 540);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(606, 540);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefono:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(820, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(992, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contraseña:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(786, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 227);
            this.label7.TabIndex = 17;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(820, 503);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(192, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Informacion de Acceso:";
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Limpiar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpiar.Location = new System.Drawing.Point(610, 612);
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.Size = new System.Drawing.Size(141, 65);
            this.BTN_Limpiar.TabIndex = 19;
            this.BTN_Limpiar.Text = "Limpiar";
            this.BTN_Limpiar.UseVisualStyleBackColor = false;
            this.BTN_Limpiar.Click += new System.EventHandler(this.BTN_Limpiar_Click);
            // 
            // TXT_Telefono
            // 
            this.TXT_Telefono.Location = new System.Drawing.Point(607, 565);
            this.TXT_Telefono.Mask = "000-000-0000";
            this.TXT_Telefono.Name = "TXT_Telefono";
            this.TXT_Telefono.Size = new System.Drawing.Size(151, 22);
            this.TXT_Telefono.TabIndex = 20;
            // 
            // TXT_DNI
            // 
            this.TXT_DNI.Location = new System.Drawing.Point(429, 566);
            this.TXT_DNI.Mask = "99999";
            this.TXT_DNI.Name = "TXT_DNI";
            this.TXT_DNI.Size = new System.Drawing.Size(151, 22);
            this.TXT_DNI.TabIndex = 21;
            this.TXT_DNI.ValidatingType = typeof(int);
            // 
            // errorProviderNombre
            // 
            this.errorProviderNombre.ContainerControl = this;
            // 
            // errorProviderApellido
            // 
            this.errorProviderApellido.ContainerControl = this;
            // 
            // errorProviderDNI
            // 
            this.errorProviderDNI.ContainerControl = this;
            // 
            // errorProviderTelefono
            // 
            this.errorProviderTelefono.ContainerControl = this;
            // 
            // errorProviderUsuario
            // 
            this.errorProviderUsuario.ContainerControl = this;
            // 
            // errorProviderClave
            // 
            this.errorProviderClave.ContainerControl = this;
            // 
            // FormUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1163, 700);
            this.ControlBox = false;
            this.Controls.Add(this.TXT_DNI);
            this.Controls.Add(this.TXT_Telefono);
            this.Controls.Add(this.BTN_Limpiar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_EliminarUsuario);
            this.Controls.Add(this.BTN_ModificarUsuario);
            this.Controls.Add(this.BTN_NuevoUsuario);
            this.Controls.Add(this.TXT_Clave);
            this.Controls.Add(this.TXT_Usuario);
            this.Controls.Add(this.TXT_Apellido);
            this.Controls.Add(this.TXT_Nombre);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormUsers";
            this.Load += new System.EventHandler(this.FormUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderClave)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_Nombre;
        private System.Windows.Forms.TextBox TXT_Apellido;
        private System.Windows.Forms.TextBox TXT_Usuario;
        private System.Windows.Forms.TextBox TXT_Clave;
        private System.Windows.Forms.Button BTN_NuevoUsuario;
        private System.Windows.Forms.Button BTN_ModificarUsuario;
        private System.Windows.Forms.Button BTN_EliminarUsuario;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BTN_Limpiar;
        private System.Windows.Forms.MaskedTextBox TXT_Telefono;
        private System.Windows.Forms.MaskedTextBox TXT_DNI;
        private System.Windows.Forms.ErrorProvider errorProviderNombre;
        private System.Windows.Forms.ErrorProvider errorProviderApellido;
        private System.Windows.Forms.ErrorProvider errorProviderDNI;
        private System.Windows.Forms.ErrorProvider errorProviderTelefono;
        private System.Windows.Forms.ErrorProvider errorProviderUsuario;
        private System.Windows.Forms.ErrorProvider errorProviderClave;
    }
}