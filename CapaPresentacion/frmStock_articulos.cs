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
    public partial class frmStock_articulos : Form
    {
        public frmStock_articulos()
        {
            InitializeComponent();
        }


        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
           
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NArticulo.Stock_articulos();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        private void frmStock_articulos_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }
    }
}
