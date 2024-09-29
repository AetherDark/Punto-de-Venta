using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocios;

namespace PuntoDeVenta_Unidad3
{
    public partial class FormUsers : Form
    {
        conexionSQLN cn = new conexionSQLN();   
        public FormUsers()
        {
            InitializeComponent();
            dataGridView1.DataSource = cn.ConsultaDT();
        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {

        }

        private void BTN_NuevoUsuario_Click(object sender, EventArgs e)
        {
            //Nombre,Apellido,DNI,Telefono,Usuario,Clave

            bool error = false;

            //Validar Nombre
            if (string.IsNullOrWhiteSpace(TXT_Nombre.Text))
            {
                errorProviderNombre.SetError(TXT_Nombre, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProviderNombre.Clear();
            }

            //Validar Apellido
            if (string.IsNullOrWhiteSpace(TXT_Apellido.Text))
            {
                errorProviderApellido.SetError(TXT_Apellido, "Ingrese un apellido valido");
                error = true;
            }
            else
            {
                errorProviderApellido.Clear();
            }

            //Validar Usuario
            if (string.IsNullOrWhiteSpace(TXT_Usuario.Text))
            {
                errorProviderUsuario.SetError(TXT_Usuario, "¡Ingrese un usuario valido!");
                error = true;
            }
            else
            {
                errorProviderUsuario.Clear();
            }

            //Validar Clave
            if (string.IsNullOrWhiteSpace(TXT_Clave.Text))
            {
                errorProviderClave.SetError(TXT_Clave, "¡Ingrese una clave valida!");
                error = true;
            }
            else
            {
                errorProviderClave.Clear();
            }

            //Validar DNI
            if (string.IsNullOrWhiteSpace(TXT_DNI.Text) || TXT_DNI.Text.Length < TXT_DNI.Mask.Length)
            {
                errorProviderDNI.SetError(TXT_DNI, "¡Ingrese un DNI valido!");
                error = true;
            }
            else
            {
                errorProviderDNI.Clear();
            }

            //Validar Telefono
            if (string.IsNullOrWhiteSpace(TXT_Telefono.Text) || TXT_Telefono.Text.Length < TXT_Telefono.Mask.Length)
            {
                errorProviderTelefono.SetError(TXT_Telefono, "¡Ingrese un DNI valido!");
                error = true;
            }
            else
            {
                errorProviderTelefono.Clear();
            }

            if (!error)
            {
                try
                {
                    cn.InsertarUsuario(TXT_Nombre.Text, TXT_Apellido.Text, TXT_DNI.Text, TXT_Telefono.Text, TXT_Usuario.Text, TXT_Clave.Text);
                    dataGridView1.DataSource = cn.ConsultaDT();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BTN_ModificarUsuario_Click(object sender, EventArgs e)
        {
            //Nombre, Apellidos, DNI, Telefono, Usuario, Clave

            bool error = false;

            //Validar Nombre
            if (string.IsNullOrWhiteSpace(TXT_Nombre.Text))
            {
                errorProviderNombre.SetError(TXT_Nombre, "¡Ingrese un nombre valido");
                error = true;
            }
            else
            {
                errorProviderNombre.Clear();
            }

            //Validar Apellido
            if (string.IsNullOrWhiteSpace(TXT_Apellido.Text))
            {
                errorProviderApellido.SetError(TXT_Apellido, "Ingrese un apellido valido");
                error = true;
            }
            else
            {
                errorProviderApellido.Clear();
            }

            //Validar Usuario
            if (string.IsNullOrWhiteSpace(TXT_Usuario.Text))
            {
                errorProviderUsuario.SetError(TXT_Usuario, "¡Ingrese un usuario valido!");
                error = true;
            }
            else
            {
                errorProviderUsuario.Clear();
            }

            //Validar Clave
            if (string.IsNullOrWhiteSpace(TXT_Clave.Text))
            {
                errorProviderClave.SetError(TXT_Clave, "¡Ingrese una clave valida!");
                error = true;
            }
            else
            {
                errorProviderClave.Clear();
            }

            //Validar DNI
            if (string.IsNullOrWhiteSpace(TXT_DNI.Text) || TXT_DNI.Text.Length < TXT_DNI.Mask.Length)
            {
                errorProviderDNI.SetError(TXT_DNI, "¡Ingrese un DNI valido!");
                error = true;
            }
            else
            {
                errorProviderDNI.Clear();
            }

            //Validar Telefono
            if (string.IsNullOrWhiteSpace(TXT_Telefono.Text) || TXT_Telefono.Text.Length < TXT_Telefono.Mask.Length)
            {
                errorProviderTelefono.SetError(TXT_Telefono, "¡Ingrese un DNI valido!");
                error = true;
            }
            else
            {
                errorProviderTelefono.Clear();
            }

            if (!error)
            {
                cn.ModificarUsuario(TXT_Nombre.Text, TXT_Apellido.Text, TXT_DNI.Text, TXT_Telefono.Text, TXT_Usuario.Text, TXT_Clave.Text);
                dataGridView1.DataSource = cn.ConsultaDT();
            }
        }

        private void BTN_EliminarUsuario_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string DNI = dataGridView1.SelectedRows[0].Cells["DNI"].Value.ToString();

                using (SqlConnection con = new SqlConnection("server = localhost; database = db_puntodeventafinal;" +
                "integrated security = true"))
                {
                    try
                    {
                        con.Open();
                        string query = "DELETE FROM Persona WHERE DNI = @DNI";
                        SqlCommand cmd = new SqlCommand(query, con);

                        cmd.Parameters.AddWithValue("@DNI", DNI);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario eliminado exitosamente");

                        dataGridView1.DataSource = cn.ConsultaDT();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al eliminar el Usuario " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un Usuario para eliminar");
            }
        }

        private void BTN_Limpiar_Click(object sender, EventArgs e)
        {
            TXT_Usuario.Text = "";
            TXT_Telefono.Text = "";
            TXT_Nombre.Text = "";
            TXT_DNI.Text = "";
            TXT_Clave.Text = "";
            TXT_Apellido.Text = "";
        }

        private void TXT_Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void TXT_DNI_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
