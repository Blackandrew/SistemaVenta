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
namespace CapaPresentacion
{
    public partial class FrmVistaCliente_Venta : Form
    {
        public FrmVistaCliente_Venta()
        {
            InitializeComponent();
        }

        private void FrmVistaCliente_Venta_Load(object sender, EventArgs e)
        {
            Mostrar();
        }

        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }


        private void Mostrar()
        {
            this.dataListado.DataSource = NClientes.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }


        private void BuscarClientes_Apellido()
        {
            this.dataListado.DataSource = NClientes.BuscarClientes_Apellido(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void Buscarcliente_num_documento()
        {
            this.dataListado.DataSource = NClientes.Buscarcliente_num_documento(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Apellidos"))
            {
                this.BuscarClientes_Apellido();
            }
            else
                if (cbbuscar.Text.Equals("Documento"))
            {
                this.Buscarcliente_num_documento();
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmVenta form = FrmVenta.GetInstancia();
            string paran1, paran2;
            paran1 = Convert.ToString(this.dataListado.CurrentRow.Cells["idcliente"].Value);
            paran2 = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value)+" "+ 
                     Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            form.setcliente(paran1, paran2);
            this.Hide();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
