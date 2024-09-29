using Capa_Negocios;
using Mysqlx;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntoDeVenta_Unidad3
{
    public partial class FormInventario : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public FormInventario()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT3();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            TXT_Producto.Text = "";
            TXT_Categoria.Text = "";
            TXT_Codigo.Text = "";
            TXT_Precio.Text = "";
            TXT_Cantidad.Text = "";
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

        }

        private void BTN_Agregar_Click(object sender, EventArgs e)
        {
            bool error = false;

            //Producto
            if (string.IsNullOrWhiteSpace(TXT_Producto.Text))
            {
                errorProvider_Producto.SetError(TXT_Producto, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Producto.Clear();
            }

            //Categoria
            if (string.IsNullOrWhiteSpace(TXT_Categoria.Text))
            {
                errorProvider_Categoria.SetError(TXT_Categoria, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Categoria.Clear();
            }

            //Codigo
            if (string.IsNullOrWhiteSpace(TXT_Codigo.Text))
            {
                errorProvider_Codigo.SetError(TXT_Codigo, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Codigo.Clear();
            }

            //Precio
            if (string.IsNullOrWhiteSpace(TXT_Precio.Text))
            {
                errorProvider_Precio.SetError(TXT_Precio, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Precio.Clear();
            }

            //Cantidad
            if (string.IsNullOrWhiteSpace(TXT_Cantidad.Text))
            {
                errorProvider_Cantidad.SetError(TXT_Cantidad, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Cantidad.Clear();
            }

            if (!error)
            {
                try
                {
                    float precio = float.Parse(TXT_Precio.Text);
                    int cantidad = int.Parse(TXT_Cantidad.Text);


                    cn.InsertarInventario(TXT_Producto.Text, TXT_Categoria.Text, precio, cantidad, TXT_Codigo.Text);
                    dataGridView1.DataSource = cn.ConsultaDT3();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_Modificar_Click(object sender, EventArgs e)
        {
            bool error = false;

            //Producto
            if (string.IsNullOrWhiteSpace(TXT_Producto.Text))
            {
                errorProvider_Producto.SetError(TXT_Producto, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Producto.Clear();
            }

            //Categoria
            if (string.IsNullOrWhiteSpace(TXT_Categoria.Text))
            {
                errorProvider_Categoria.SetError(TXT_Categoria, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Categoria.Clear();
            }

            //Precio
            if (string.IsNullOrWhiteSpace(TXT_Precio.Text))
            {
                errorProvider_Precio.SetError(TXT_Precio, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Precio.Clear();
            }

            //Cantidad
            if (string.IsNullOrWhiteSpace(TXT_Cantidad.Text))
            {
                errorProvider_Cantidad.SetError(TXT_Cantidad, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Cantidad.Clear();
            }

            //Codigo
            if (string.IsNullOrWhiteSpace(TXT_Codigo.Text))
            {
                errorProvider_Codigo.SetError(TXT_Codigo, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProvider_Codigo.Clear();
            }

            if (!error)
            {
                float precio = float.Parse(TXT_Precio.Text);
                int cantidad = int.Parse(TXT_Cantidad.Text);

                cn.ModificarInventario(TXT_Producto.Text, TXT_Categoria.Text, precio, cantidad, TXT_Codigo.Text);
                dataGridView1.DataSource = cn.ConsultaDT3();
            }
        }

        private void BTN_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string Codigo = dataGridView1.SelectedRows[0].Cells["Codigo"].Value.ToString();

                using (SqlConnection con = new SqlConnection("server = localhost; database = db_puntodeventafinal;" +
                "integrated security = true"))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Inventario WHERE Codigo = @Codigo";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@Codigo", Codigo);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Producto eliminado exitosamente");

                        dataGridView1.DataSource = cn.ConsultaDT3();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Producto " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Producto para eliminar");
            }
        }
    }
}
