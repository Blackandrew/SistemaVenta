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
    public partial class FrmVistaArticulo_venta : Form
    {
        public FrmVistaArticulo_venta()
        {
            InitializeComponent();
        }

        private void FrmVistaArticulo_venta_Load(object sender, EventArgs e)
        {

        }

        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        

        private void mostrararticulo_venta_nombre()
        {
            this.dataListado.DataSource = NVenta.mostrararticulo_venta_nombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void mostrararticulo_venta_codigo()
        {
            this.dataListado.DataSource = NVenta.mostrararticulo_venta_codigo(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (cbbuscar.Text.Equals("Codigo"))
            {
                this.mostrararticulo_venta_codigo();
            }
            else
            if (cbbuscar.Text.Equals("Nombre"))
            {
                this.mostrararticulo_venta_nombre();
            }
            
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {

            FrmVenta form = FrmVenta.GetInstancia();
            string par1, par2;
            decimal par3, par4;
            int par5;
            DateTime par6;

            par1 =Convert.ToString( this.dataListado.CurrentRow.Cells["iddetalle_ingreso"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Categoria"].Value);
            par3 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_compra"].Value);
            par4 = Convert.ToDecimal(this.dataListado.CurrentRow.Cells["precio_venta"].Value);
            par5 = Convert.ToInt32(this.dataListado.CurrentRow.Cells["stock_actual"].Value);
            par6 = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_vencimiento"].Value);

            form.setarticulo(par1, par2, par3, par4, par5, par6);
            this.Hide();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
