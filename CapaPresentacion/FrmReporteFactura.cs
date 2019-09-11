using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CapaPresentacion
{
    public partial class FrmReporteFactura : Form
    {

        private int idventa;

        public int Idventa
        {
            get { return idventa; }
            set { idventa = value; }
        }
        public FrmReporteFactura()
        {
         

            try
            {
                InitializeComponent();

            }
            catch ( System.IO.FileLoadException EX)
            {
              
            } 
          
        }

        private void FrmReporteFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DsPrincipal.reporte_factura' Puede moverla o quitarla según sea necesario.

            try
            {
                this.reporte_facturaTableAdapter.Fill(this.DsPrincipal.reporte_factura, Idventa);
               
                this.reportViewer1.RefreshReport();

            }
            catch (Exception EX) {
                this.reportViewer1.RefreshReport();
            }
                
         
        }
    }
}
