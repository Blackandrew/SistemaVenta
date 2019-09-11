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
    public partial class Frmvistaproveedor_ingreso : Form
    {
        public Frmvistaproveedor_ingreso()
        {
            InitializeComponent();
        }

        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Metodo Mostrar

        private void Mostrar()
        {
            this.dataListado.DataSource = NProveedor.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarRazon_Social()
        {
            this.dataListado.DataSource = NProveedor.BuscarRazon_Social(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }
        private void BuscarNum_Documento()
        {
            this.dataListado.DataSource = NProveedor.BuscarNum_Documento(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Frmvistaproveedor_ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Razon Social"))
            {
                this.BuscarRazon_Social();
            }
            else if (cbbuscar.Text.Equals("Documento"))
                this.BuscarNum_Documento();
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngresos form = FrmIngresos.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString( this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            form.setProveedor(par1,par2);
            this.Hide();
        }
    }
}
