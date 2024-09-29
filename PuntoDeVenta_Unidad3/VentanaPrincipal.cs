using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;

namespace PuntoDeVenta_Unidad3
{
    public partial class VentanaPrincipal : Form
    {
        conexionSQLN cn = new conexionSQLN();

        private DataTable DT;

        private double SubTotal = 0;
        private double Total = 0;
        private double Descuento = 0;
        private string Cliente = "";

        public VentanaPrincipal()
        {
            InitializeComponent();
            dataGridView_Productos.DataSource = cn.ConsultaDT2();

            DT = new DataTable();
            DT.Columns.Add("Codigo");
            DT.Columns.Add("Producto");
            DT.Columns.Add("Precio x Unidad");
            DT.Columns.Add("Cantidad");
            DT.Columns.Add("Descuento");
            DT.Columns.Add("SubTotal");

            dataGridView1.DataSource = DT;

            TXT_NoFactura.Text = cn.ConsultaFactura();

            TXT_ImpVenta.Text = TXT_ImpVentaEdit.Text;
            TXT_Descuento.Text = TXT_DescuentoEdit.Text;
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUsers v1 = new FormUsers();
            this.Hide();
            v1.ShowDialog();
            this.Show();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
        }

        private void MenuItem_Inventario_Click(object sender, EventArgs e)
        {
            FormInventario v2 = new FormInventario();
            this.Hide();
            v2.ShowDialog();
            this.Show();
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void TXT_ImpVentaDescuentos_Click(object sender, EventArgs e)
        {
            
        }

        private void ImpVentaYDescuentoChanged(object sender, EventArgs e)
        {
            TXT_ImpVenta.Text = TXT_ImpVentaEdit.Text;
            TXT_Descuento.Text = TXT_DescuentoEdit.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var resultado = cn.ConsultaInventario(TXT_CodigoProducto.Text);
            DataRow row = DT.NewRow();

            row["Codigo"] = TXT_CodigoProducto.Text;
            row["Producto"] = resultado.Item1;
            row["Precio x Unidad"] = resultado.Item2;
            row["Cantidad"] = TXT_Cantidad.Text;
            row["Descuento"] = TXT_Descuento.Text;
            row["SubTotal"] = Int32.Parse(TXT_Cantidad.Text) * double.Parse(resultado.Item2);

            DT.Rows.Add(row);

            SubTotal = SubTotal + (Int32.Parse(TXT_Cantidad.Text) * double.Parse(resultado.Item2));

            if (Descuento == 0)
            {
                Total = SubTotal + (SubTotal * double.Parse(TXT_ImpVentaEdit.Text));
            }
            else
            {
                Total = SubTotal + (SubTotal * double.Parse(TXT_ImpVentaEdit.Text));
                Total = Total - (Total * Descuento);
            }

            LBL_SubTotal.Text = SubTotal.ToString();
            LBL_Total.Text = Total.ToString();
        }

        private void BTN_Buscar_Click(object sender, EventArgs e)
        {
            var resultado2 = cn.ConsultaClientes(TXT_CodigoCliente.Text);

            TXT_Cliente.Text = resultado2.Item1 + " DESC: " + resultado2.Item2;
            Descuento = resultado2.Item2;
        }

        private void BTN_Facturar_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura();
            List<Factura> ListaFactura = new List<Factura>();

            foreach (DataRow row in DT.Rows)
            {
                factura.Codigo = row["Codigo"].ToString();
                factura.Producto = row["Producto"].ToString();
                factura.PrecioxUnidad = row["Precio x Unidad"].ToString();
                factura.Cantidad = row["Cantidad"].ToString();
                factura.Descuento = row["Descuento"].ToString();
                factura.PrecioTotal = row["SubTotal"].ToString();
                factura.SubTotal = SubTotal.ToString();
                factura.Cliente = Cliente.ToString();
                factura.ClienteDescuento = Descuento.ToString();
                factura.Total = Total.ToString();
                factura.NFactura1 = TXT_NoFactura.Text;

                ListaFactura.Add(factura);
            }

            MessageBox.Show(ListaFactura.Count().ToString());
        }
    }
}
