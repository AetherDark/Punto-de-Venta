using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Capa_Negocios;

namespace PuntoDeVenta_Unidad3
{
    public partial class Login : Form
    {
        conexionSQLN cn = new conexionSQLN();
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = TXT_Usuario.Text.Trim();
                string clave = TXT_Clave.Text.Trim();
                int result = cn.conSQL(usuario, clave);

                if (result > 0)
                {
                    VentanaPrincipal v1 = new VentanaPrincipal();
                    v1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("No se ha encontrado informacion", "Error", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
