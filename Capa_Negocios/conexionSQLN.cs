using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;

namespace Capa_Negocios
{
    public class conexionSQLN
    {
        Conexion cn = new Conexion();

        public int conSQL (string user, string pass)
        {
            return cn.consultalogin (user, pass);
        }

        public DataTable ConsultaDT2()
        {
            return cn.ConsultaInventarioDG();
        }

        public DataTable ConsultaDT3()
        {
            return cn.ConsultaInventario2DG();
        }

        public DataTable ConsultaDT ()
        {
            return cn.ConsultaUsuariosDG();
        }

        public int InsertarUsuario(string Nombre, string Apellidos, string DNI, string Telefono, string Usuario, string Clave)
        {
            return cn.InsertarUsuario(Nombre,Apellidos,DNI,Telefono,Usuario,Clave);
        }

        public int ModificarUsuario(string Nombre, string Apellidos, string DNI, string Telefono, string Usuario, string Clave)
        {
            return cn.ModificarUsuario(Nombre, Apellidos, DNI, Telefono, Usuario, Clave);
        }

        public string ConsultaFactura()
        {
            return cn.Consultafactura();
        }

        public Tuple<string, string> ConsultaInventario(string code)
        {
            return cn.ConsultaInventario(code);
        }

        public int InsertarInventario(string Producto, string Categoria, float Precio, int Cantidad, string Codigo)
        {
            return cn.InsertarInventario(Producto, Categoria, Precio, Cantidad, Codigo);
        }

        public int ModificarInventario(string Producto, string Categoria, float Precio, int Cantidad, string Codigo)
        {
            return cn.ModificarInventario(Producto, Categoria, Precio, Cantidad, Codigo);
        }

        public Tuple<string, double> ConsultaClientes(string code)
        {
            return cn.ConsultaCliente(code);
        }
    }
}
