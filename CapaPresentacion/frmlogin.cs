using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using System.Data.SqlClient;

namespace CapaPresentacion
{
    public partial class frmlogin : Form
    {
        public frmlogin()
        {
            InitializeComponent();
            lbhora.Text = DateTime.Now.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbhora.Text = DateTime.Now.ToString();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Dato = NTrabajador.Login(this.txtusuario.Text,this.txtpas.Text);
                //evaluar si existe el usuario

                if (Dato.Rows.Count == 0)
                {
                    MessageBox.Show("No tiene acceso al sistema", "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //creamo la instancia y le pasamos los datos segun su parametros
                    frmPrincipal frm = new frmPrincipal();
                    frm.Idtrabajador = Dato.Rows[0][0].ToString();
                    frm.apellidos = Dato.Rows[0][1].ToString();
                    frm.nombre = Dato.Rows[0][2].ToString();
                    frm.acceso = Dato.Rows[0][3].ToString();
                    frm.Show();
                    this.Hide();
                }
                    


            } catch (Exception ex) {
            }
                ;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
