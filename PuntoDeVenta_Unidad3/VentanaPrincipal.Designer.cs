namespace PuntoDeVenta_Unidad3
{
    partial class VentanaPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItem_Archivo = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_ImpVentaDescuentos = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_ImpVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_ImpVentaEdit = new System.Windows.Forms.ToolStripTextBox();
            this.MenuItem_Descuento = new System.Windows.Forms.ToolStripMenuItem();
            this.TXT_DescuentoEdit = new System.Windows.Forms.ToolStripTextBox();
            this.MenuItem_Usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Inventario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem_Reportes = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BTN_Cerrar = new System.Windows.Forms.Button();
            this.TXT_CodigoProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_AgregarProducto = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_SubTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LBL_Total = new System.Windows.Forms.Label();
            this.TXT_Descuento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Facturar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_Cantidad = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.TXT_ImpVenta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TXT_NoFactura = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.TXT_CodigoCliente = new System.Windows.Forms.TextBox();
            this.BTN_Buscar = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_Cliente = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.dataGridView_Productos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.DarkRed;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_Archivo,
            this.MenuItem_Usuarios,
            this.MenuItem_Inventario,
            this.MenuItem_Reportes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1232, 55);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItem_Archivo
            // 
            this.MenuItem_Archivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TXT_ImpVentaDescuentos});
            this.MenuItem_Archivo.ForeColor = System.Drawing.Color.White;
            this.MenuItem_Archivo.Name = "MenuItem_Archivo";
            this.MenuItem_Archivo.Size = new System.Drawing.Size(73, 51);
            this.MenuItem_Archivo.Text = "Archivo";
            // 
            // TXT_ImpVentaDescuentos
            // 
            this.TXT_ImpVentaDescuentos.BackColor = System.Drawing.Color.DarkRed;
            this.TXT_ImpVentaDescuentos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem_ImpVenta,
            this.MenuItem_Descuento});
            this.TXT_ImpVentaDescuentos.ForeColor = System.Drawing.Color.White;
            this.TXT_ImpVentaDescuentos.Name = "TXT_ImpVentaDescuentos";
            this.TXT_ImpVentaDescuentos.Size = new System.Drawing.Size(253, 26);
            this.TXT_ImpVentaDescuentos.Text = "Imp. Venta y Descuentos";
            this.TXT_ImpVentaDescuentos.Click += new System.EventHandler(this.TXT_ImpVentaDescuentos_Click);
            // 
            // MenuItem_ImpVenta
            // 
            this.MenuItem_ImpVenta.BackColor = System.Drawing.Color.DarkRed;
            this.MenuItem_ImpVenta.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TXT_ImpVentaEdit});
            this.MenuItem_ImpVenta.ForeColor = System.Drawing.Color.White;
            this.MenuItem_ImpVenta.Name = "MenuItem_ImpVenta";
            this.MenuItem_ImpVenta.Size = new System.Drawing.Size(162, 26);
            this.MenuItem_ImpVenta.Text = "Imp. Venta";
            // 
            // TXT_ImpVentaEdit
            // 
            this.TXT_ImpVentaEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ImpVentaEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_ImpVentaEdit.Name = "TXT_ImpVentaEdit";
            this.TXT_ImpVentaEdit.Size = new System.Drawing.Size(100, 27);
            this.TXT_ImpVentaEdit.Text = "0.09";
            this.TXT_ImpVentaEdit.TextChanged += new System.EventHandler(this.ImpVentaYDescuentoChanged);
            // 
            // MenuItem_Descuento
            // 
            this.MenuItem_Descuento.BackColor = System.Drawing.Color.DarkRed;
            this.MenuItem_Descuento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TXT_DescuentoEdit});
            this.MenuItem_Descuento.ForeColor = System.Drawing.Color.White;
            this.MenuItem_Descuento.Name = "MenuItem_Descuento";
            this.MenuItem_Descuento.Size = new System.Drawing.Size(162, 26);
            this.MenuItem_Descuento.Text = "Descuento";
            // 
            // TXT_DescuentoEdit
            // 
            this.TXT_DescuentoEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_DescuentoEdit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TXT_DescuentoEdit.Name = "TXT_DescuentoEdit";
            this.TXT_DescuentoEdit.Size = new System.Drawing.Size(100, 27);
            this.TXT_DescuentoEdit.Text = "0";
            this.TXT_DescuentoEdit.TextChanged += new System.EventHandler(this.ImpVentaYDescuentoChanged);
            // 
            // MenuItem_Usuarios
            // 
            this.MenuItem_Usuarios.ForeColor = System.Drawing.Color.White;
            this.MenuItem_Usuarios.Name = "MenuItem_Usuarios";
            this.MenuItem_Usuarios.Size = new System.Drawing.Size(79, 51);
            this.MenuItem_Usuarios.Text = "Usuarios";
            this.MenuItem_Usuarios.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // MenuItem_Inventario
            // 
            this.MenuItem_Inventario.ForeColor = System.Drawing.Color.White;
            this.MenuItem_Inventario.Name = "MenuItem_Inventario";
            this.MenuItem_Inventario.Size = new System.Drawing.Size(89, 51);
            this.MenuItem_Inventario.Text = "Inventario";
            this.MenuItem_Inventario.Click += new System.EventHandler(this.MenuItem_Inventario_Click);
            // 
            // MenuItem_Reportes
            // 
            this.MenuItem_Reportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.MenuItem_Reportes.ForeColor = System.Drawing.Color.White;
            this.MenuItem_Reportes.Name = "MenuItem_Reportes";
            this.MenuItem_Reportes.Size = new System.Drawing.Size(82, 51);
            this.MenuItem_Reportes.Text = "Reportes";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.DarkRed;
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 26);
            this.toolStripMenuItem1.Text = "Historial de Facturas";
            // 
            // BTN_Cerrar
            // 
            this.BTN_Cerrar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cerrar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Cerrar.Location = new System.Drawing.Point(1109, 662);
            this.BTN_Cerrar.Name = "BTN_Cerrar";
            this.BTN_Cerrar.Size = new System.Drawing.Size(111, 43);
            this.BTN_Cerrar.TabIndex = 1;
            this.BTN_Cerrar.Text = "Cerrar";
            this.BTN_Cerrar.UseVisualStyleBackColor = false;
            this.BTN_Cerrar.Click += new System.EventHandler(this.BTN_Cerrar_Click);
            // 
            // TXT_CodigoProducto
            // 
            this.TXT_CodigoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CodigoProducto.Location = new System.Drawing.Point(34, 105);
            this.TXT_CodigoProducto.Name = "TXT_CodigoProducto";
            this.TXT_CodigoProducto.Size = new System.Drawing.Size(374, 22);
            this.TXT_CodigoProducto.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 34);
            this.label1.TabIndex = 3;
            // 
            // BTN_AgregarProducto
            // 
            this.BTN_AgregarProducto.BackColor = System.Drawing.Color.Gold;
            this.BTN_AgregarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_AgregarProducto.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_AgregarProducto.Location = new System.Drawing.Point(34, 604);
            this.BTN_AgregarProducto.Name = "BTN_AgregarProducto";
            this.BTN_AgregarProducto.Size = new System.Drawing.Size(195, 72);
            this.BTN_AgregarProducto.TabIndex = 4;
            this.BTN_AgregarProducto.Text = "Agregar Producto";
            this.BTN_AgregarProducto.UseVisualStyleBackColor = false;
            this.BTN_AgregarProducto.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(838, 393);
            this.dataGridView1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(37, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Codigo del Producto:";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(639, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "SubTotal:";
            // 
            // LBL_SubTotal
            // 
            this.LBL_SubTotal.BackColor = System.Drawing.Color.DarkRed;
            this.LBL_SubTotal.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_SubTotal.ForeColor = System.Drawing.Color.White;
            this.LBL_SubTotal.Location = new System.Drawing.Point(747, 76);
            this.LBL_SubTotal.Name = "LBL_SubTotal";
            this.LBL_SubTotal.Size = new System.Drawing.Size(114, 22);
            this.LBL_SubTotal.TabIndex = 8;
            this.LBL_SubTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(34, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(752, 34);
            this.label5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkRed;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(527, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Por pagar:";
            // 
            // LBL_Total
            // 
            this.LBL_Total.BackColor = System.Drawing.Color.DarkRed;
            this.LBL_Total.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_Total.ForeColor = System.Drawing.Color.White;
            this.LBL_Total.Location = new System.Drawing.Point(645, 548);
            this.LBL_Total.Name = "LBL_Total";
            this.LBL_Total.Size = new System.Drawing.Size(122, 22);
            this.LBL_Total.TabIndex = 11;
            this.LBL_Total.Text = "0.00";
            // 
            // TXT_Descuento
            // 
            this.TXT_Descuento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Descuento.Location = new System.Drawing.Point(969, 548);
            this.TXT_Descuento.Name = "TXT_Descuento";
            this.TXT_Descuento.Size = new System.Drawing.Size(224, 22);
            this.TXT_Descuento.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DarkRed;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(808, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 34);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.DarkRed;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(818, 548);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 22);
            this.label9.TabIndex = 14;
            this.label9.Text = "Descuento:";
            // 
            // BTN_Facturar
            // 
            this.BTN_Facturar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Facturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Facturar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Facturar.Location = new System.Drawing.Point(257, 604);
            this.BTN_Facturar.Name = "BTN_Facturar";
            this.BTN_Facturar.Size = new System.Drawing.Size(195, 72);
            this.BTN_Facturar.TabIndex = 15;
            this.BTN_Facturar.Text = "Facturar";
            this.BTN_Facturar.UseVisualStyleBackColor = false;
            this.BTN_Facturar.Click += new System.EventHandler(this.BTN_Facturar_Click);
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.DarkRed;
            this.label10.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(420, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 22);
            this.label10.TabIndex = 16;
            this.label10.Text = "Cantidad:";
            // 
            // TXT_Cantidad
            // 
            this.TXT_Cantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cantidad.Location = new System.Drawing.Point(414, 105);
            this.TXT_Cantidad.Name = "TXT_Cantidad";
            this.TXT_Cantidad.Size = new System.Drawing.Size(127, 22);
            this.TXT_Cantidad.TabIndex = 17;
            this.TXT_Cantidad.Text = "1";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkRed;
            this.label11.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(902, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 22);
            this.label11.TabIndex = 20;
            this.label11.Text = "Imp. Venta:";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.DarkRed;
            this.label12.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(888, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 34);
            this.label12.TabIndex = 19;
            // 
            // TXT_ImpVenta
            // 
            this.TXT_ImpVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_ImpVenta.Location = new System.Drawing.Point(1060, 76);
            this.TXT_ImpVenta.Name = "TXT_ImpVenta";
            this.TXT_ImpVenta.Size = new System.Drawing.Size(133, 22);
            this.TXT_ImpVenta.TabIndex = 18;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.DarkRed;
            this.label13.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(548, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 22);
            this.label13.TabIndex = 23;
            this.label13.Text = "No. Factura:";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.DarkRed;
            this.label14.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(548, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(119, 22);
            this.label14.TabIndex = 22;
            // 
            // TXT_NoFactura
            // 
            this.TXT_NoFactura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_NoFactura.Location = new System.Drawing.Point(688, 105);
            this.TXT_NoFactura.Name = "TXT_NoFactura";
            this.TXT_NoFactura.Size = new System.Drawing.Size(184, 22);
            this.TXT_NoFactura.TabIndex = 21;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.DarkRed;
            this.label15.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(495, 593);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 22);
            this.label15.TabIndex = 26;
            this.label15.Text = "Codigo Cliente:";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.DarkRed;
            this.label16.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(485, 585);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(173, 34);
            this.label16.TabIndex = 25;
            // 
            // TXT_CodigoCliente
            // 
            this.TXT_CodigoCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_CodigoCliente.Location = new System.Drawing.Point(664, 593);
            this.TXT_CodigoCliente.Name = "TXT_CodigoCliente";
            this.TXT_CodigoCliente.Size = new System.Drawing.Size(122, 22);
            this.TXT_CodigoCliente.TabIndex = 24;
            // 
            // BTN_Buscar
            // 
            this.BTN_Buscar.BackColor = System.Drawing.Color.Gold;
            this.BTN_Buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Buscar.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_Buscar.Location = new System.Drawing.Point(533, 637);
            this.BTN_Buscar.Name = "BTN_Buscar";
            this.BTN_Buscar.Size = new System.Drawing.Size(195, 39);
            this.BTN_Buscar.TabIndex = 27;
            this.BTN_Buscar.Text = "Buscar";
            this.BTN_Buscar.UseVisualStyleBackColor = false;
            this.BTN_Buscar.Click += new System.EventHandler(this.BTN_Buscar_Click);
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.DarkRed;
            this.label17.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(888, 105);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 22);
            this.label17.TabIndex = 29;
            this.label17.Text = "Cliente:";
            // 
            // TXT_Cliente
            // 
            this.TXT_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TXT_Cliente.Location = new System.Drawing.Point(989, 105);
            this.TXT_Cliente.Name = "TXT_Cliente";
            this.TXT_Cliente.Size = new System.Drawing.Size(231, 22);
            this.TXT_Cliente.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(1199, 80);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 18);
            this.label18.TabIndex = 30;
            this.label18.Text = "%";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial Black", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(1199, 552);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 18);
            this.label19.TabIndex = 31;
            this.label19.Text = "%";
            // 
            // dataGridView_Productos
            // 
            this.dataGridView_Productos.AllowUserToAddRows = false;
            this.dataGridView_Productos.AllowUserToDeleteRows = false;
            this.dataGridView_Productos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Productos.Location = new System.Drawing.Point(892, 133);
            this.dataGridView_Productos.Name = "dataGridView_Productos";
            this.dataGridView_Productos.ReadOnly = true;
            this.dataGridView_Productos.RowHeadersWidth = 51;
            this.dataGridView_Productos.RowTemplate.Height = 24;
            this.dataGridView_Productos.Size = new System.Drawing.Size(328, 393);
            this.dataGridView_Productos.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(732, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 22);
            this.label4.TabIndex = 33;
            this.label4.Text = "$";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(628, 548);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 22);
            this.label7.TabIndex = 34;
            this.label7.Text = "$";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1232, 717);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView_Productos);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.TXT_Cliente);
            this.Controls.Add(this.BTN_Buscar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.TXT_CodigoCliente);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.TXT_NoFactura);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TXT_ImpVenta);
            this.Controls.Add(this.TXT_Cantidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.BTN_Facturar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TXT_Descuento);
            this.Controls.Add(this.LBL_Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_SubTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BTN_AgregarProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TXT_CodigoProducto);
            this.Controls.Add(this.BTN_Cerrar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentanaPrincipal";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Productos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Archivo;
        private System.Windows.Forms.ToolStripMenuItem TXT_ImpVentaDescuentos;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Usuarios;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Inventario;
        private System.Windows.Forms.Button BTN_Cerrar;
        private System.Windows.Forms.TextBox TXT_CodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_AgregarProducto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_SubTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LBL_Total;
        private System.Windows.Forms.TextBox TXT_Descuento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Reportes;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Button BTN_Facturar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TXT_Cantidad;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TXT_ImpVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TXT_NoFactura;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TXT_CodigoCliente;
        private System.Windows.Forms.Button BTN_Buscar;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TXT_Cliente;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_ImpVenta;
        private System.Windows.Forms.ToolStripMenuItem MenuItem_Descuento;
        private System.Windows.Forms.ToolStripTextBox TXT_ImpVentaEdit;
        private System.Windows.Forms.ToolStripTextBox TXT_DescuentoEdit;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.DataGridView dataGridView_Productos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
    }
}