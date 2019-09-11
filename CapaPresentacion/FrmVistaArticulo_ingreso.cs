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
    public partial class FrmVistaArticulo_ingreso : Form
    {
        public FrmVistaArticulo_ingreso()
        {
            InitializeComponent();
        }


        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
            this.dataListado.Columns[6].Visible = false;
            this.dataListado.Columns[8].Visible = false;
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NArticulo.BuscarNombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }
        private void FrmVistaArticulo_ingreso_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            FrmIngresos form = FrmIngresos.GetInstancia();
            string paran1, paran2;
            paran1 =  Convert.ToString( this.dataListado.CurrentRow.Cells["idarticulo"].Value);
            paran2= Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            form.setArticulo(paran1, paran2);
            this.Hide();
        }
    }
}
