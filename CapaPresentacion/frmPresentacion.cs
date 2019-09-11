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
    public partial class frmPresentacion : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;

        public frmPresentacion()
        {
            InitializeComponent();
            this.ttmensajes.SetToolTip(this.txtnombre, "ingrese el nombre de la Presentación");
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
            this.txtdescripcion.Text = string.Empty;
            this.txtidpresentacion.Text = string.Empty;

        }

        //habilitar los controles del formulario

        private void Habilitar(bool valor)
        {
            this.txtnombre.ReadOnly = !valor;
            this.txtdescripcion.ReadOnly = !valor;
            this.txtidpresentacion.ReadOnly = !valor;

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
            this.dataListado.DataSource = NPresentacion.Mostrar();
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }

        //Metodo buscarnombre
        private void BuscarNombre()
        {
            this.dataListado.DataSource = NPresentacion.BuscarNombre(this.txtBuscar.Text);
            this.Ocultarcolumnas();
            lbTotal.Text = "Total de Registro: " + Convert.ToString(dataListado.Rows.Count);//total de registrado
        }
        private void frmPresentacion_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
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

                if (this.txtnombre.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                    errorIcono.SetError(txtnombre, "Ingrese el nombre");

                }
                else
                {
                    if (this.IsNuevo)
                    {
                        rpta = NPresentacion.Insertar(this.txtnombre.Text.Trim().ToUpper(),
                            this.txtdescripcion.Text.Trim());
                    }

                    else
                    {
                        rpta = NPresentacion.Editar(Convert.ToInt32(this.txtidpresentacion.Text), this.txtnombre.Text.Trim().ToUpper(),
                              this.txtdescripcion.Text.Trim());
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
            if (!this.txtidpresentacion.Text.Equals(""))
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
                            rpta = NPresentacion.Eliminar(Convert.ToInt32(codigo));

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
                    if (chkEliminar.Checked==true)
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
            this.txtidpresentacion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtdescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

            this.tabControl1.SelectedIndex = 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
