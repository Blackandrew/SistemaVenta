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
    public partial class frmvVistaCategoria_Articulo : Form
    {
        public frmvVistaCategoria_Articulo()
        {
            InitializeComponent();
        }
        //ocultar columna
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
        }

        //Metodo Mostrar

        private void Mostrar()
        {
            this.dataListado.DataSource = NCategoria.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NCategoria.BuscarNombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }
        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmvVistaCategoria_Articulo_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            frmArticulo form = frmArticulo._GetInstancia();
            string par1, par2;
            par1 =Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            form.setcategoria(par1,par2);
            this.Hide();
        }
    }
}
