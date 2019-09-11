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
using System.Text.RegularExpressions;
namespace CapaPresentacion
{
    public partial class frmCliente : Form
    {
        private bool IsNuevo = false;
        private bool IsEditar = false;
        public frmCliente()
        {
            InitializeComponent();
            this.ttmensajes.SetToolTip(this.txtnombre, "Ingrese el nombre del cliente");//se muestra los mensajes de error
            this.ttmensajes.SetToolTip(this.txtapellido, "Ingrese el apellido del cliente");
            this.ttmensajes.SetToolTip(this.txtdireccion, "Ingrese la direccion del cliente");
            this.ttmensajes.SetToolTip(this.txtnum_documento, "Ingrese el numero de documento del cliente");
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
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txtnum_documento.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtidcliente.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;

        }
        //habilitar los controles del formulario

        private void Habilitar(bool valor)
        {
            this.txtidcliente.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor;
            this.txtapellido.ReadOnly = !valor;
            this.txtnum_documento.ReadOnly = !valor;
            this.txttelefono.ReadOnly = !valor;
            this.txtemail.ReadOnly = !valor;
            this.cbsexo.Enabled = valor;
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



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void frmCliente_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if(cbbuscar.Text.Equals("Apellidos"))
            {
                this.BuscarClientes_Apellido();
            }
            else
                 if (cbbuscar.Text.Equals("Documento"))
            {
                this.Buscarcliente_num_documento();
            }
          
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
                            rpta = NClientes.Eliminar(Convert.ToInt32(codigo));

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
                this.txtemail.Focus();
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
            this.txtidcliente.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcliente"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtapellido.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["apellidos"].Value);
            this.cbsexo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["sexo"].Value);
            this.dtfechaname.Value = Convert.ToDateTime(this.dataListado.CurrentRow.Cells["fecha_nacimiento"].Value);
            this.cbtipo_documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["tipo_documento"].Value);
            this.txtnum_documento.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["num_documento"].Value);
            this.txtdireccion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["direccion"].Value);
            this.txttelefono.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["telefono"].Value);
            this.txtemail.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["email"].Value);
            
            this.tabControl1.SelectedIndex = 1;

            this.dataListado.DataSource = NClientes.Mostrar();
            this.Ocultarcolumnas();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                int cant= Convert.ToInt32(this.txttelefono.Text.Length);

                if  ( (ComprobarFormatoEmail(this.txtemail.Text)== true )  &&  (cant==8))
                {
                    if (this.txtnombre.Text == string.Empty || this.txtapellido.Text == string.Empty
                    || this.txtnum_documento.Text == string.Empty || this.txtdireccion.Text == string.Empty)
                    {
                        mensajeerror("Falta ingrese algunos datos");
                        errorIcono.SetError(txtnombre, "Ingrese el nombre");
                        errorIcono.SetError(txtapellido, "Ingrese el apellido");
                        errorIcono.SetError(txtnum_documento, "Ingrese el numero de documento");
                        errorIcono.SetError(txtdireccion, "Ingrese la dirección");

                    }

                    else
                    {
                        if (this.IsNuevo)
                        {
                            rpta = NClientes.Insertar(this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(),
                                this.cbsexo.Text.Trim().ToUpper(), this.dtfechaname.Value, this.cbtipo_documento.Text.Trim(),
                               this.txtnum_documento.Text.Trim().ToUpper(), this.txtdireccion.Text.Trim().ToUpper(),
                               this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim().ToUpper());
                        }

                        else
                        {
                            rpta = NClientes.Editar(Convert.ToInt32(this.txtidcliente.Text.Trim().ToUpper()), this.txtnombre.Text.Trim().ToUpper(), this.txtapellido.Text.Trim().ToUpper(),
                               this.cbsexo.Text.Trim().ToUpper(), this.dtfechaname.Value, this.cbtipo_documento.Text.Trim(),
                              this.txtnum_documento.Text.Trim().ToUpper(), this.txtdireccion.Text.Trim().ToUpper(),
                              this.txttelefono.Text.Trim().ToUpper(), this.txtemail.Text.Trim().ToUpper());
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
                else if (ComprobarFormatoEmail(this.txtemail.Text) == false)
                {
                    MessageBox.Show("CORREO INCORRECTO!!!", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidcliente.Text.Equals(""))
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataListado.DataSource = NClientes.Mostrar();
            this.Ocultarcolumnas();
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {

        }

        public static bool ComprobarFormatoEmail(string sEmailAComprobar)
        {
            String sFormato;
            string email;
            email = sEmailAComprobar;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, sFormato))
            {
                if (Regex.Replace(email, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsNumber(e.KeyChar))//Si es número
            {
                e.Handled = false;
            }
            else if (e.KeyChar == (char)Keys.Back)//si es tecla borrar
            {
                e.Handled = false;
            }
            else //Si es otra tecla cancelamos
            {
                MessageBox.Show("Solo se permiten Numeros");
                e.Handled = true;

            }
                        

        }

        private void cbbuscar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
        
}

