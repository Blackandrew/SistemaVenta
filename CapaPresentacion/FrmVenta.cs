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
using CapaPresentacion;

namespace CapaPresentacion
{
    public partial class FrmVenta : Form
    {

        private bool Isnuevo = false;
        public int Idtrabajador;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private static FrmVenta _Instancia;

        public static FrmVenta GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new FrmVenta();
            }

            return _Instancia;
        }


        public void setarticulo(string iddetalle_ingreso,string nombre,decimal precio_compra,
            decimal precio_venta,int stock,DateTime fecha_vencimiento)
        {
            this.txtidarticulo.Text = iddetalle_ingreso;
            this.txtarticulo.Text = nombre;
            this.txtpreciocompra.Text =Convert.ToString(precio_compra);
            this.txtprecioventa.Text= Convert.ToString(precio_venta);
            this.txtstock_actual.Text = Convert.ToString(stock); ;
            this.dtfechavencimiento.Value = fecha_vencimiento;
            
        }

        public void setcliente(string idcliente, string nombre)
        {
            this.txtidcliente.Text = idcliente;
            this.txtcliente.Text = nombre;
        }

        public FrmVenta()
        {
            InitializeComponent();
            this.ttmensajes.SetToolTip(this.txtcliente, "Seleccione un cliente");
            this.ttmensajes.SetToolTip(this.txtserie, "Seleccione la serie del comprobante");
            this.ttmensajes.SetToolTip(this.txtcorrelativo, "ingrese un numero del comprobante");
            this.ttmensajes.SetToolTip(this.txtcantidad, "ingrese la cantidad de articulo");
            this.ttmensajes.SetToolTip(this.txtarticulo, "Seleccione un articulo");

            this.txtidarticulo.Visible = false;
            this.txtidcliente.Visible = false;
            this.txtcliente.ReadOnly = true;
            this.txtarticulo.ReadOnly = true;
            this.dtfechavencimiento.Enabled = false;
            this.txtpreciocompra.ReadOnly = true;
            this.txtstock_actual.ReadOnly = true;




        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarFechas();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
            this.creartabla();
        }

        private void FrmVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            _Instancia = null;
        }

        private void btnbuscarcliente_Click(object sender, EventArgs e)
        {
            FrmVistaCliente_Venta vista  = new FrmVistaCliente_Venta();
            vista.ShowDialog();

        }

        private void btnbuscararticulo_Click(object sender, EventArgs e)
        {
            FrmVistaArticulo_venta vista = new FrmVistaArticulo_venta();
            vista.ShowDialog();
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
            this.txtidventa.Text = string.Empty;
            this.txtidcliente.Text = string.Empty;
            this.txtcliente.Text = string.Empty;
            this.txtserie.Text = string.Empty;
            this.txtcorrelativo.Text = string.Empty;
            this.txtigv.Text = string.Empty;
            this.lbltotalpagado.Text = "0,0";
            this.txtigv.Text = "18";
            this.creartabla();



        }

        private void limpiarDetalle()
        {
            this.txtidarticulo.Text = string.Empty;
            this.txtarticulo.Text = string.Empty;
            this.txtstock_actual.Text = string.Empty;
            this.txtcantidad.Text = string.Empty;
            this.txtpreciocompra.Text = string.Empty;
            this.txtprecioventa.Text = string.Empty;
            this.txtdescuento.Text = string.Empty;


        }
        private void Habilitar(bool valor)
        {
            this.txtidventa.ReadOnly = !valor;
            this.txtserie.ReadOnly = !valor;
            this.txtcorrelativo.ReadOnly = !valor;

            this.txtigv.ReadOnly = !valor;
            this.dtfecha.Enabled = valor;
            this.cbTipo_comprobante.Enabled = valor;
            this.txtcantidad.ReadOnly = !valor;
            this.txtdescuento.ReadOnly = !valor;
            this.txtstock_actual.ReadOnly = !valor;
            this.txtpreciocompra.ReadOnly = !valor;
            this.txtprecioventa.ReadOnly = !valor;

           
            this.dtfechavencimiento.Enabled = valor;

            this.btnbuscararticulo.Enabled = valor;
            this.btnbuscarcliente.Enabled = valor;

            this.btnagregar.Enabled = valor;
            this.btnquitar.Enabled = valor;



        }


        // habilitar los botones

        private void Botones()
        {
            if (this.Isnuevo)
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
            this.dataListado.DataSource = NVenta.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarFechas()
        {
            this.dataListado.DataSource = NVenta.BuscarFechas(this.dtfecha1.Value.ToString("dd/MM/yyyy"),
                this.dtfecha2.Value.ToString("dd/MM/yyyy"));
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }



        private void MostrarDetalle()
        {
            this.dataListadodetalle.DataSource = NVenta.MostrarDetalles(this.txtidventa.Text);

        }


        private void creartabla()
        {
            this.dtDetalle = new DataTable("Detalle");
            this.dtDetalle.Columns.Add("iddetalle_Ingreso", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("articulo", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("Cantidad", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("Descuento", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            //relacionar datagriview con datatable

            this.dataListadodetalle.DataSource = this.dtDetalle;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Usted Eliminara un registro! ", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            rpta = NVenta.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Se Elimino el registro correctamente");
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

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidventa.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idventa"].Value);
            this.txtcliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Cliente"].Value);
            this.dtfecha.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha"].Value);
            this.cbTipo_comprobante.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_comprobante"].Value);
            this.txtserie.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["serie"].Value);
            this.txtcorrelativo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["correlativo"].Value);
            this.lbltotalpagado.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["total"].Value);
            this.MostrarDetalle();
            this.tabControl1.SelectedIndex = 1;
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.Isnuevo = true;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txtserie.Focus();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Isnuevo = false;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(false);
            this.txtserie.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtserie.Text == string.Empty
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


                    if (this.Isnuevo)
                    {
                        rpta = NVenta.Insertar(Convert.ToInt32(this.txtidcliente.Text),Idtrabajador,
                            dtfecha.Value, cbTipo_comprobante.Text, txtserie.Text, txtcorrelativo.Text,
                            Convert.ToDecimal(txtigv.Text), dtDetalle
                           );
                    }



                    if (rpta.Equals("OK"))
                    {
                        if (this.Isnuevo)
                        {
                            this.mensajeok("Se inserto de forma correcta");
                        }

                    }

                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    this.Isnuevo = false;

                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                    this.Mostrar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace + "PRUEBA");
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {


                if (this.txtidarticulo.Text == string.Empty
                    || this.txtcantidad.Text == string.Empty || this.txtdescuento.Text == string.Empty
                     || this.txtprecioventa.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                    errorIcono.SetError(txtidarticulo, "Ingrese un valor");
                    errorIcono.SetError(txtcantidad, "Ingrese  un valor");
                    errorIcono.SetError(txtdescuento, "Ingrese un valor");
                    errorIcono.SetError(txtprecioventa, "Ingrese un valor ");

                }
                else
                {
                    bool registrar = true;

                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["iddetalle_ingreso"]) == Convert.ToInt32(this.txtidarticulo.Text))
                        {
                            registrar = false;
                            this.mensajeerror("Ya se encuentra el articulo registrado");
                        }
                    }
                    if (registrar && Convert.ToInt32(txtcantidad.Text) <= Convert.ToInt32(txtstock_actual.Text)  )
                    {

                        decimal subtotal = (Convert.ToInt32(this.txtcantidad.Text)) * (Convert.ToDecimal(this.txtprecioventa.Text)-Convert.ToDecimal(txtdescuento.Text));
                        totalPagado = totalPagado + subtotal;
                        this.lbltotalpagado.Text = totalPagado.ToString("#0.00#");
                        //agregar ese detalle al datalistadodetalle
                        DataRow row = this.dtDetalle.NewRow();
                        row["iddetalle_ingreso"] = Convert.ToUInt32(this.txtidarticulo.Text);
                        row["articulo"] = this.txtarticulo.Text;
                        row["cantidad"] = Convert.ToDecimal(this.txtcantidad.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtprecioventa.Text);
                        row["descuento"] = Convert.ToUInt32(this.txtdescuento.Text);
                        row["subtotal"] = subtotal;
                        this.dtDetalle.Rows.Add(row); //se le agrega el objeto
                        this.limpiarDetalle();

                    }
                    else
                    {
                        mensajeerror("No hay stock suficiente");
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
                DataRow row = this.dtDetalle.Rows[indicarfila];//hace referencia al indic que se quitara del datagriview
                //disminuir total pagado
                this.totalPagado = this.totalPagado - Convert.ToDecimal((row["subtotal"].ToString()));
                this.lbltotalpagado.Text = totalPagado.ToString("#0.00#");
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                mensajeerror("No hay filas para eliminar");
            }
        }

        private void btncomprobante_Click(object sender, EventArgs e)
        {

            FrmReporteFactura frm = new FrmReporteFactura();

           frm.Idventa = Convert.ToInt32(this.dataListado.CurrentRow.Cells["idventa"].Value);
            frm.ShowDialog();
        }
    }
}
