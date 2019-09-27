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
    public partial class FrmIngresos : Form
    {
        private static FrmIngresos _Instancia;
        public int id_trabajador;
        private bool IsNuevo;
        private DataTable dtDEtale;
        private decimal totalPagado = 0;
       
        public static FrmIngresos GetInstancia()
        {
            if(_Instancia == null)
            {
                _Instancia = new FrmIngresos();
            }

            return _Instancia;
        }
        public FrmIngresos()
        {
            InitializeComponent();
            this.ttmensajes.SetToolTip(this.txtidproveedor, "Seleccione el Proveedor");
            this.ttmensajes.SetToolTip(this.txtserie, "Seleccione la serie del comprobante");
            this.ttmensajes.SetToolTip(this.txtcorrelativo,"Ingrese eL numero del comprobante");
            this.ttmensajes.SetToolTip(this.txtstock,"Ingrese la cantidad de compra");
            this.ttmensajes.SetToolTip(this.txtarticulo, "Seleccione el articulo");
            this.txtidproveedor.Visible = false;
            this.txtidarticulo.Visible = false;
            this.txtproveedor.ReadOnly = true;//solo lectura
            this.txtarticulo.ReadOnly = true;
        }


        //metodo para establecer los valores de proveedor
        public void setProveedor(string idproveedor,string nombre)
        {
            this.txtidproveedor.Text = idproveedor;
            this.txtproveedor.Text = nombre;
        }

        public void setArticulo(string idarticulo,string nombre)
        {
            this.txtidarticulo.Text = idarticulo;
            this.txtarticulo.Text = nombre;
        }

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //mostrar mensaje de error

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Limpiar()
        {
            this.txtidingresos.Text = string.Empty;
            this.txtidproveedor.Text = string.Empty;
            this.txtproveedor.Text = string.Empty;
            this.txtserie.Text = string.Empty;
            this.txtcorrelativo.Text = string.Empty;
            this.txtigv.Text = string.Empty;
            this.lbltotalpagado.Text = "0,0";
            this.txtigv.Text = "18";
            this.creartabla();



        }

        private void limpiarDetalle()
        {
            this.txtidarticulo.Text= string.Empty;
            this.txtarticulo.Text = string.Empty;
            this.txtstock.Text = string.Empty;
            this.txtpreciocompra.Text = string.Empty;
            this.txtprecioventa.Text = string.Empty;

        }
        private void Habilitar(bool valor)
        {
            this.txtidingresos.ReadOnly = !valor;
            this.txtserie.ReadOnly = !valor;
            this.txtcorrelativo.ReadOnly = !valor;
           
            this.txtigv.ReadOnly = !valor;
            this.dtfecha.Enabled = valor;
            this.cbTipo_comprobante.Enabled = valor;
            this.txtstock.ReadOnly = !valor;
            this.txtpreciocompra.ReadOnly = !valor;
            this.txtprecioventa.ReadOnly = !valor;

            this.dtfechaproduccion.Enabled = valor;
            this.dtfechavencimiento.Enabled = valor;
         
            this.btnbuscararticulo.Enabled = valor;
            this.btnbuscarproveedor.Enabled = valor;
            this.btnagregar.Enabled = valor;
            this.btnquitar.Enabled = valor;



        }


        // habilitar los botones

        private void Botones()
        {
            if (this.IsNuevo)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btncancelar.Enabled = true;
            }

            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btncancelar.Enabled = false;
            }
        }


        //ocultar columnas
        private void Ocultarcolumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
          
        }

        private void Mostrar()
        {
            this.dataListado.DataSource = NIngresos.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarFechas()
        {
            this.dataListado.DataSource = NIngresos.BuscarFechas( this.dtfecha1.Value.ToString("dd/MM/yyyy"), 
                this.dtfecha2.Value.ToString("dd/MM/yyyy"));
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }



        private void MostrarDetalle()
        {
            this.dataListadodetalle.DataSource = NIngresos.MostrarDetalles(this.txtidingresos.Text)  ;
          
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Usted Anulará un registro! ", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (opcion == DialogResult.OK)
                {
                    string codigo;
                    string rpta = "";
                    //RECORRE EL DATA PARA ELIMINAR LAS COLUM SELECC
                    foreach (DataGridViewRow row in dataListado.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToString(row.Cells[1].Value);
                            rpta = NIngresos.Anular(Convert.ToInt32(codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Se Anulo el registro correctamente");
                            }
                            else
                            {
                                this.mensajeok(rpta);
                            }
                        }
                    }
                    if (chkEliminar.Checked == true)
                    {
                        chkEliminar.Checked = false;

                    }
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtidcategoria_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(false);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscarcategoria_Click(object sender, EventArgs e)
        {
            Frmvistaproveedor_ingreso vista = new Frmvistaproveedor_ingreso();
            vista.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void FrmIngresos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.creartabla();
            
        }

        private void FrmIngresos_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            FrmVistaArticulo_ingreso vista = new FrmVistaArticulo_ingreso();
            vista.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void chkEliminar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEliminar.Checked)
            {
                this.dataListado.Columns[0].Visible = true;

            }

            else
            {
                this.dataListado.Columns[0].Visible = false;
            }
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void creartabla()
        {
            this.dtDEtale = new DataTable("Detalle");
            this.dtDEtale.Columns.Add("idarticulo", System.Type.GetType("System.Int32"));
            this.dtDEtale.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDEtale.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDEtale.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDEtale.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDEtale.Columns.Add("stock_actual", System.Type.GetType("System.Int32"));
            this.dtDEtale.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDEtale.Columns.Add("fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDEtale.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            //relacionar datagriview con datatable

            this.dataListadodetalle.DataSource = this.dtDEtale;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txtserie.Focus();
            
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if ( this.txtserie.Text == string.Empty 
                    || this.txtcorrelativo.Text == string.Empty || this.txtigv.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                  
                    errorIcono.SetError(txtserie, "Ingrese la serie");
                    errorIcono.SetError(txtcorrelativo, "Ingrese el el correlativo");
                    errorIcono.SetError(txtigv, "Ingrese el igv");

                }
                else
                {
                    //almacena en el bufer lo que esta en el picturebox,luego se asigana 
                   

                    if (this.IsNuevo)
                    {
                        rpta = NIngresos.Insertar(this.id_trabajador,Convert.ToInt32( this.txtidproveedor.Text),
                            dtfecha.Value,cbTipo_comprobante.Text,txtserie.Text,txtcorrelativo.Text,
                            Convert.ToDecimal(txtigv.Text),"Emitido",dtDEtale
                           );
                    }
                   


                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.mensajeok("Se inserto de forma correcta");
                        }
                     
                    }

                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    this.IsNuevo = false;
                   
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace+"PRUEBA");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {
              

                if ( this.txtstock.Text == string.Empty
                    || this.txtpreciocompra.Text == string.Empty || this.txtprecioventa.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                    errorIcono.SetError(txtidarticulo, "Ingrese un valor");
                    errorIcono.SetError(txtstock, "Ingrese  un valor");
                    errorIcono.SetError(txtpreciocompra, "Ingrese un valor");
                    errorIcono.SetError(txtprecioventa, "Ingrese un valor ");

                }
                else
                {
                    bool registrar = true;

                    foreach(DataRow row in dtDEtale.Rows)
                    {
                        if (Convert.ToInt32(row["idarticulo"])==Convert.ToInt32(this.txtidarticulo.Text))
                        {
                            registrar = false;
                            this.mensajeerror("Ya se encuentra el articulo registrado");
                        }
                    }
                    if (registrar)
                    {

                        decimal subtotal = (Convert.ToDecimal(this.txtstock.Text)) * (Convert.ToDecimal(  this.txtpreciocompra.Text) );
                        totalPagado = totalPagado + subtotal;
                        this.lbltotalpagado.Text = totalPagado.ToString("#0.00#");
                        //agregar ese detalle al datalistadodetalle
                        DataRow row = this.dtDEtale.NewRow();
                        row["idarticulo"] = Convert.ToUInt32( this.txtidarticulo.Text);
                        row["articulo"] = this.txtarticulo.Text;
                        row["precio_compra"] =  Convert.ToDecimal( this.txtpreciocompra.Text);
                        row["precio_venta"]= Convert.ToDecimal(this.txtprecioventa.Text);
                        row["stock_inicial"]= Convert.ToUInt32(this.txtstock.Text);
                        row["stock_actual"] = Convert.ToUInt32(this.txtstock.Text);
                        row["fecha_produccion"] = dtfechaproduccion.Value ;
                        row["fecha_vencimiento"] = dtfechavencimiento.Value;
                        row["subtotal"] = subtotal;
                        this.dtDEtale.Rows.Add(row); //se le agrega el objeto
                        this.limpiarDetalle();


                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                int indicarfila = this.dataListadodetalle.CurrentCell.RowIndex;
                DataRow row = this.dtDEtale.Rows[indicarfila];//hace referencia al indic que se quitara del datagriview
                //disminuir total pagado
                this.totalPagado = this.totalPagado - Convert.ToDecimal((row["subtotal"].ToString()));
                this.lbltotalpagado.Text = totalPagado.ToString("#0.00#");
                this.dtDEtale.Rows.Remove(row);
            }
            catch (Exception ex) {
                mensajeerror("No hay filas para eliminar");
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            //NOMBRES  de las columnas  de los procedimientos
            this.txtidingresos.Text = Convert.ToString(  this.dataListado.CurrentRow.Cells["idingreso"].Value);
            this.txtproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["proveedor"].Value);
            this.dtfecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbTipo_comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtserie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
           this.txtcorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
            this.lbltotalpagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
        }

        private void FrmIngresos_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void dataListadodetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
