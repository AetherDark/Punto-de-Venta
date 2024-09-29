using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Factura
    {
        private string codigo = "";
        private string producto = "";
        private string precioxUnidad = "";
        private string cantidad = "";
        private string descuento = "";
        private string subTotal = "";
        private string precioTotal = "";
        private string cliente = "";
        private string clienteDescuento = "";
        private string total = "";
        private string NFactura = "";

        public string Codigo { get => codigo; set => codigo = value; }
        public string Producto { get => producto; set => producto = value; }
        public string PrecioxUnidad { get => precioxUnidad; set => precioxUnidad = value; }
        public string Cantidad { get => cantidad; set => cantidad = value; }
        public string Descuento { get => descuento; set => descuento = value; }
        public string SubTotal { get => subTotal; set => subTotal = value; }
        public string PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string Cliente { get => cliente; set => cliente = value; }
        public string ClienteDescuento { get => clienteDescuento; set => clienteDescuento = value; }
        public string Total { get => total; set => total = value; }
        public string NFactura1 { get => NFactura; set => NFactura = value; }
    }
}
