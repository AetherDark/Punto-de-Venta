using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Net.Http.Headers;
using System.CodeDom;

namespace Capa_Datos
{
    public class Conexion
    {
        static string conexionstring = "Server=localhost\\SQLEXPRESS;Database=db_PuntoDeVenta;Trusted_Connection=True";

        SqlConnection con = new SqlConnection(conexionstring);

        public int consultalogin(string Usuario, string Clave)
        {
            int count = 0;
            try
            {
                con.Open();

                string query = "SELECT COUNT(*) FROM Persona WHERE Usuario = @Usuario AND Clave = @Clave";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Usuario", Usuario);
                cmd.Parameters.AddWithValue("@Clave", Clave);

                count = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                throw new Exception("Buen intento");
            }
            catch (Exception ex)
            {
                throw new Exception("Error inesperado" + ex.Message);
            }
            finally
            {
                con.Close();
            }
            return count;
        }

        public int InsertarUsuario(string Nombre, string Apellidos, string DNI, string Telefono, string Usuario, string Clave)
        {
            int flag = 0;
            try
            {
                con.Open();

                string query = "INSERT INTO Persona (Nombre, Apellidos, DNI, Telefono, Usuario, Clave)" +
                    "VALUES ('" + Nombre + "', '" + Apellidos + "', '" + DNI + "', '" + Telefono + "', '" + Usuario + "', '" + Clave + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("El DNI o el Usuario ingresado ya existe, por favor ingrese uno nuevo");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                con.Close();
            }
            return flag;
        }

        public int ModificarUsuario(string Nombre, string Apellidos, string DNI, string Telefono, string Usuario, string Clave)
        {
            int flag = 0;
            con.Open();

            string query = "Update Persona set Nombre ='" + Nombre + "',Apellidos ='" + Apellidos + "'," +
                "Telefono ='" + Telefono + "', Usuario ='" + Usuario + "', Clave ='" + Clave + "' where DNI = '" + DNI + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaInventarioDG()
        {
            string query = "select Producto, Codigo from Inventario";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public DataTable ConsultaInventario2DG()
        {
            string query = "select * from Inventario";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public int InsertarInventario(string Producto, string Categoria, float Precio, int Cantidad, string Codigo)
        {
            int flag = 0;
            try
            {
                con.Open();

                string query = "INSERT INTO Inventario (ProducTo, Categoria, Precio, Cantidad, Codigo)" +
                    "VALUES ('" + Producto + "', '" + Categoria + "', '" + Precio + "', '" + Cantidad + "', '" + Codigo + "')";
                SqlCommand cmd = new SqlCommand(query, con);
                flag = cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("El Codigo o el Producto ingresado ya existe, por favor ingrese uno nuevo");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                con.Close();
            }
            return flag;
        }

        public int ModificarInventario(string Producto, string Categoria, float Precio, int Cantidad, string Codigo)
        {
            int flag = 0;
            con.Open();

            string query = "Update Inventario set Producto ='" + Producto + "',Categoria ='" + Categoria + "'," +
                "Precio ='" + Precio + "', Cantidad ='" + Cantidad + "', Codigo ='" + Codigo + "' where Codigo = '" + Codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            flag = cmd.ExecuteNonQuery();
            con.Close();
            return flag;
        }

        public DataTable ConsultaUsuariosDG()
        {
            string query = "select * from Persona";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            data.Fill(tabla);

            return tabla;
        }

        public string Consultafactura()
        {
            con.Open();
            string resultado = "Null";

            string query = "Select (Select distinct top 1 NumFactura from Facturacion order by NumFactura desc) +1 as NumFactura";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["NumFactura"].ToString();
            }

            con.Close();
            return resultado;
        }

        public Tuple<string, string> ConsultaInventario(string Codigo)
        {
            con.Open();

            string resultado = "Null";
            string resultado1 = "Null";

            string query = "Select * From Inventario where Codigo = '" + Codigo + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["Producto"].ToString();
                resultado1 = reg["Precio"].ToString();
            }
                
            con.Close();
            return Tuple.Create(resultado, resultado1);
        }

        public Tuple<string, double> ConsultaCliente(string Codigo)
        {
            con.Open();

            string resultado = "Null";
            double resultado1 = 0;

            string query = "Select [NombreCliente] +' '+[ApellidoCliente] as Nombre , [Descuento] from [Clientes] Where [CodigoCliente] = '"+Codigo+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader reg = cmd.ExecuteReader();

            if (reg.Read())
            {
                resultado = reg["Nombre"].ToString();
                resultado1 = double.Parse(reg["Descuento"].ToString());
            }

            con.Close();
            return Tuple.Create(resultado, resultado1);
        }
    }
}
