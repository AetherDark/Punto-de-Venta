namespace PuntoDeVenta_Unidad3
{
    partial class FormInventario
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
            this.TXT_Producto = new System.Windows.Forms.TextBox();
            this.TXT_Categoria = new System.Windows.Forms.TextBox();
            this.TXT_Codigo = new System.Windows.Forms.TextBox();
            this.TXT_Precio = new System.Windows.Forms.MaskedTextBox();
            this.TXT_Cantidad = new System.Windows.Forms.MaskedTextBox();
            this.BTN_Agregar = new System.Windows.Forms.Button();
            this.BTN_Modificar = new System.Windows.Forms.Button();
            this.BTN_Eliminar = new System.Windows.Forms.Button();
            this.BTN_Limpiar = new System.Windows.Forms.Button();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider_Producto = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Categoria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Codigo = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Precio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider_Cantidad = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Codigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Precio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1117, 465);
            this.dataGridView1.TabIndex = 0;
            // 
            // TXT_Producto
            // 
            this.TXT_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Producto.Location = new System.Drawing.Point(83, 543);
            this.TXT_Producto.Name = "TXT_Producto";
            this.TXT_Producto.Size = new System.Drawing.Size(155, 22);
            this.TXT_Producto.TabIndex = 1;
            // 
            // TXT_Categoria
            // 
            this.TXT_Categoria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Categoria.Location = new System.Drawing.Point(288, 543);
            this.TXT_Categoria.Name = "TXT_Categoria";
            this.TXT_Categoria.Size = new System.Drawing.Size(155, 22);
            this.TXT_Categoria.TabIndex = 2;
            // 
            // TXT_Codigo
            // 
            this.TXT_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Codigo.Location = new System.Drawing.Point(481, 543);
            this.TXT_Codigo.Name = "TXT_Codigo";
            this.TXT_Codigo.Size = new System.Drawing.Size(155, 22);
            this.TXT_Codigo.TabIndex = 3;
            // 
            // TXT_Precio
            // 
            this.TXT_Precio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Precio.Location = new System.Drawing.Point(687, 543);
            this.TXT_Precio.Mask = "99999";
            this.TXT_Precio.Name = "TXT_Precio";
            this.TXT_Precio.Size = new System.Drawing.Size(155, 22);
            this.TXT_Precio.TabIndex = 4;
            this.TXT_Precio.ValidatingType = typeof(int);
            // 
            // TXT_Cantidad
            // 
            this.TXT_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cantidad.Location = new System.Drawing.Point(892, 543);
            this.TXT_Cantidad.Mask = "99999";
            this.TXT_Cantidad.Name = "TXT_Cantidad";
            this.TXT_Cantidad.Size = new System.Drawing.Size(155, 22);
            this.TXT_Cantidad.TabIndex = 5;
            this.TXT_Cantidad.ValidatingType = typeof(int);
            // 
            // BTN_Agregar
            // 
            this.BTN_Agregar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Agregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Agregar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Agregar.Location = new System.Drawing.Point(83, 603);
            this.BTN_Agregar.Name = "BTN_Agregar";
            this.BTN_Agregar.Size = new System.Drawing.Size(141, 61);
            this.BTN_Agregar.TabIndex = 6;
            this.BTN_Agregar.Text = "Nuevo Producto";
            this.BTN_Agregar.UseVisualStyleBackColor = false;
            this.BTN_Agregar.Click += new System.EventHandler(this.BTN_Agregar_Click);
            // 
            // BTN_Modificar
            // 
            this.BTN_Modificar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Modificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Modificar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Modificar.Location = new System.Drawing.Point(288, 602);
            this.BTN_Modificar.Name = "BTN_Modificar";
            this.BTN_Modificar.Size = new System.Drawing.Size(141, 61);
            this.BTN_Modificar.TabIndex = 7;
            this.BTN_Modificar.Text = "Modificar Producto";
            this.BTN_Modificar.UseVisualStyleBackColor = false;
            this.BTN_Modificar.Click += new System.EventHandler(this.BTN_Modificar_Click);
            // 
            // BTN_Eliminar
            // 
            this.BTN_Eliminar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Eliminar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Eliminar.Location = new System.Drawing.Point(481, 602);
            this.BTN_Eliminar.Name = "BTN_Eliminar";
            this.BTN_Eliminar.Size = new System.Drawing.Size(141, 61);
            this.BTN_Eliminar.TabIndex = 8;
            this.BTN_Eliminar.Text = "Eliminar Producto";
            this.BTN_Eliminar.UseVisualStyleBackColor = false;
            this.BTN_Eliminar.Click += new System.EventHandler(this.BTN_Eliminar_Click);
            // 
            // BTN_Limpiar
            // 
            this.BTN_Limpiar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Limpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Limpiar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Limpiar.Location = new System.Drawing.Point(687, 603);
            this.BTN_Limpiar.Name = "BTN_Limpiar";
            this.BTN_Limpiar.Size = new System.Drawing.Size(141, 61);
            this.BTN_Limpiar.TabIndex = 9;
            this.BTN_Limpiar.Text = "Limpiar";
            this.BTN_Limpiar.UseVisualStyleBackColor = false;
            this.BTN_Limpiar.Click += new System.EventHandler(this.BTN_Limpiar_Click);
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cerrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cerrar.Location = new System.Drawing.Point(892, 602);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(141, 61);
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
            this.label1.Location = new System.Drawing.Point(79, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 11;
            this.label1.Text = "Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(284, 521);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 12;
            this.label2.Text = "Categoria:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(477, 521);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 13;
            this.label3.Text = "Codigo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(683, 521);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "Precio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(888, 521);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cantidad:";
            // 
            // errorProvider_Producto
            // 
            this.errorProvider_Producto.ContainerControl = this;
            // 
            // errorProvider_Categoria
            // 
            this.errorProvider_Categoria.ContainerControl = this;
            // 
            // errorProvider_Codigo
            // 
            this.errorProvider_Codigo.ContainerControl = this;
            // 
            // errorProvider_Precio
            // 
            this.errorProvider_Precio.ContainerControl = this;
            // 
            // errorProvider_Cantidad
            // 
            this.errorProvider_Cantidad.ContainerControl = this;
            // 
            // FormInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1163, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.BTN_Limpiar);
            this.Controls.Add(this.BTN_Eliminar);
            this.Controls.Add(this.BTN_Modificar);
            this.Controls.Add(this.BTN_Agregar);
            this.Controls.Add(this.TXT_Cantidad);
            this.Controls.Add(this.TXT_Precio);
            this.Controls.Add(this.TXT_Codigo);
            this.Controls.Add(this.TXT_Categoria);
            this.Controls.Add(this.TXT_Producto);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInventario";
            this.Load += new System.EventHandler(this.FormInventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Codigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Precio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider_Cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox TXT_Producto;
        private System.Windows.Forms.TextBox TXT_Categoria;
        private System.Windows.Forms.TextBox TXT_Codigo;
        private System.Windows.Forms.MaskedTextBox TXT_Precio;
        private System.Windows.Forms.MaskedTextBox TXT_Cantidad;
        private System.Windows.Forms.Button BTN_Agregar;
        private System.Windows.Forms.Button BTN_Modificar;
        private System.Windows.Forms.Button BTN_Eliminar;
        private System.Windows.Forms.Button BTN_Limpiar;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider_Producto;
        private System.Windows.Forms.ErrorProvider errorProvider_Categoria;
        private System.Windows.Forms.ErrorProvider errorProvider_Codigo;
        private System.Windows.Forms.ErrorProvider errorProvider_Precio;
        private System.Windows.Forms.ErrorProvider errorProvider_Cantidad;
    }
}