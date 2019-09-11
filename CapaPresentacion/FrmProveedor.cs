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
    public partial class FrmProveedor : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        public FrmProveedor()
        {
            InitializeComponent();
            this.ttmensajes.SetToolTip(this.txtrazon_social, "Ingrese el nombre de la Razon Social del proveedor");
            this.ttmensajes.SetToolTip(this.txtnum_documento, "Ingrese el Número de Documento");
            this.ttmensajes.SetToolTip(this.txtdireccion, "Ingrese la Dirección");
        }

        //mostrar mensaje de confirmacion

        private void mensajeok(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //mostrar mensaje de error

        private void mensajeerror(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de ventas", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //limpiar controles del formulario
        private void Limpiar()
        {
            this.txtrazon_social.Text = string.Empty;
            this.txtnum_documento.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txturl.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtidproveedor.Text = string.Empty;


        }

        //habilitar los controles del formulario

        private void Habilitar(bool valor)
        {
            this.txtrazon_social.ReadOnly = !valor;
            this.txtidproveedor.ReadOnly = !valor;
            this.txtdireccion.ReadOnly = !valor;
            this.txtnum_documento.ReadOnly = !valor;
            this.txttelefono.ReadOnly = !valor;
            this.txturl.ReadOnly = !valor;
            this.txtemail.ReadOnly = !valor;
            this.cbsector_comercial.Enabled = valor;
            this.cbtipo_documento.Enabled = valor;
           
        }


        // habilitar los botones

        private void Botones()
        {
            if (this.IsNuevo || this.IsEditar)
            {
                this.Habilitar(true);
                this.btnNuevo.Enabled = false;
                this.btnguardar.Enabled = true;
                this.btneditar.Enabled = false;
                this.btncancelar.Enabled = true;
            }

            else
            {
                this.Habilitar(false);
                this.btnNuevo.Enabled = true;
                this.btnguardar.Enabled = false;
                this.btneditar.Enabled = true;
                this.btncancelar.Enabled = false;
            }
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Usted eliminará un registro! ", "Sistema de Ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

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
                            rpta = NProveedor.Eliminar(Convert.ToInt32(codigo));

                            if (rpta.Equals("OK"))
                            {
                                this.mensajeok("Se elimino el registro correctamente");
                            }
                            else
                            {
                                this.mensajeok(rpta);
                            }
                        }
                    }

                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtrazon_social.Focus();

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";

                if (this.txtrazon_social.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                    errorIcono.SetError(txtrazon_social, "Ingrese la razon social");

                }

                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NProveedor.Insertar(this.txtrazon_social.Text.Trim().ToUpper(),
                            this.cbsector_comercial.Text.Trim().ToUpper(), this.cbtipo_documento.Text.Trim().ToUpper(),
                           this.txtnum_documento.Text.Trim().ToUpper(), this.txtdireccion.Text.Trim().ToUpper(),
                           this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim().ToUpper(), this.txturl.Text.Trim().ToUpper());
                    }

                    else
                    {
                        rpta = NProveedor.Editar(Convert.ToInt32(this.txtidproveedor.Text.ToUpper()), this.txtrazon_social.Text.Trim().ToUpper(),
                            this.cbsector_comercial.Text.Trim().ToUpper(), this.cbtipo_documento.Text.Trim().ToUpper(),
                           this.txtnum_documento.Text.Trim().ToUpper(), this.txtdireccion.Text.Trim().ToUpper(),
                           this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim().ToUpper(), this.txturl.Text.Trim().ToUpper());
                    }

                    if (rpta.Equals("OK"))
                    {
                        if (this.IsNuevo)
                        {
                            this.mensajeok("Se inserto de forma correcta");
                        }
                        else
                        {
                            this.mensajeok("Se Actualizó de forma correcta");
                        }
                    }

                    else
                    {
                        this.mensajeerror(rpta);
                    }

                    this.IsNuevo = false;
                    this.IsEditar = false;
                    this.Botones();
                    this.Limpiar();
                    this.Mostrar();

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidproveedor.Text.Equals(""))
            {
                this.IsEditar = true;
                this.Botones();
                this.Habilitar(true);
            }
            else
            {
                this.mensajeerror("Debe seleccionar primero el registro  a modificar ");
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {

            this.txtidproveedor.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idproveedor"].Value);
            this.txtrazon_social.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["razon_social"].Value);
            this.cbsector_comercial.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sector_comercial"].Value);
            this.cbtipo_documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtnum_documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtdireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txttelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtemail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            this.txturl.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["url"].Value);


            this.tabControl1.SelectedIndex = 1;
        }
    }
}
