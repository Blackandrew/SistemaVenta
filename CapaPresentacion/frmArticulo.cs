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
    public partial class frmArticulo : Form
    {

        private bool IsNuevo = false;
        private bool IsEditar = false;
        private static frmArticulo _Instancia;

        //metodo para crear instancia par aenviar valores a vistacategoriaariticulo
        public static frmArticulo _GetInstancia()
        {
            if(_Instancia==null)
            {
                _Instancia = new frmArticulo();
                
            }

            return _Instancia;
        }

        public void setcategoria(string idcategoria,string nombre)
        {
            this.txtidcategoria.Text = idcategoria;
            this.txtcategoria.Text = nombre;

        }



        public frmArticulo()
        {
            InitializeComponent();
            //muestra mensaje al pasar el mouse por los controles
            this.ttmensajes.SetToolTip(this.txtnombre, "Ingrese el nombre del Artículo");
            this.ttmensajes.SetToolTip(this.pximagen, "Selecciona la imagen del Artículo");
            this.ttmensajes.SetToolTip(this.cbidpresentacion, "Seleccione la presentacion del Artículo");
            this.ttmensajes.SetToolTip(this.txtcategoria, "Selecciona la categoria del Artículo");

            //ocultar controles

            this.txtidcategoria.Visible = false;
            this.txtcategoria.ReadOnly = true;
            this.llenarcombopresentacion();
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
            this.txtidarticulo.Text = string.Empty;
            this.txtcodigo.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
            this.txtidcategoria.Text = string.Empty;
            this.txtcategoria.Text = string.Empty;
            this.cbidpresentacion.Text = string.Empty;
            this.pximagen.Image = Image.FromFile(@"C:\Users\msolis\Desktop\iconos\descargar.jpg");
           

        }
        private void Habilitar(bool valor)
        {
            this.txtcodigo.ReadOnly = !valor;
            this.txtnombre.ReadOnly = !valor;
            this.txtdescripcion.ReadOnly = !valor;
            this.txtidarticulo.ReadOnly = !valor;
            this.btnbuscarcategoria.Enabled = valor;
            this.cbidpresentacion.Enabled = valor;
            this.btncargar.Enabled = valor;
            this.btnlimpiar.Enabled = valor;

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

        private void llenarcombopresentacion()
        {
            cbidpresentacion.DataSource = NPresentacion.Mostrar();
            cbidpresentacion.ValueMember = "idpresentacion";
            cbidpresentacion.DisplayMember = "nombre";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataListado.Columns["Eliminar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dataListado.Rows[e.RowIndex].Cells["Eliminar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void lbTotal_Click(object sender, EventArgs e)
        {

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

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
                            rpta = NCategoria.Eliminar(Convert.ToInt32(codigo));

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.BuscarNombre();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(false);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (!this.txtidcategoria.Text.Equals(""))
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

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";

                if (this.txtnombre.Text == string.Empty || this.txtidcategoria.Text == string.Empty || this.txtcodigo.Text == string.Empty)
                {
                    mensajeerror("Falta ingrese algunos datos");
                    errorIcono.SetError(txtnombre, "Ingrese el nombre");
                    errorIcono.SetError(txtcodigo, "Ingrese el nombre");
                    errorIcono.SetError(txtcategoria, "Ingrese el nombre");

                }
                else
                {
                    //almacena en el bufer lo que esta en el picturebox,luego se asigana 
                    System.IO.MemoryStream ms = new System.IO.MemoryStream();
                    this.pximagen.Image.Save(ms,System.Drawing.Imaging.ImageFormat.Png);
                    byte[] imagen = ms.GetBuffer();

                    if (this.IsNuevo)
                    {
                        rpta = NArticulo.Insertar(this.txtcodigo.Text.Trim().ToUpper(), this.txtnombre.Text.Trim().ToUpper(),
                            this.txtdescripcion.Text.Trim(),imagen,Convert.ToInt32(txtidcategoria.Text), Convert.ToInt32(this.cbidpresentacion.SelectedValue));
                    }
                  
                    else
                    {
                        rpta = NArticulo.Editar(Convert.ToInt32(this.txtidarticulo.Text),this.txtcodigo.Text.Trim().ToUpper(), this.txtnombre.Text.Trim().ToUpper(),
                            this.txtdescripcion.Text.Trim(), imagen, Convert.ToInt32(txtidcategoria.Text), Convert.ToInt32(this.cbidpresentacion.SelectedValue));
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.IsEditar = false;
            this.Botones();
            this.Limpiar();
            this.Habilitar(true);
            this.txtnombre.Focus();
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtidpresentacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void ttmensajes_Popup(object sender, PopupEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btncargar_Click(object sender, EventArgs e)
        {

            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK)
            {  //linea de codigo para que la imagen cargada se acople al componente
                this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pximagen.Image = Image.FromFile(dialog.FileName);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.Mostrar();
            this.Habilitar(false);
            this.Botones();
        }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pximagen.Image= Image.FromFile(@"C:\Users\msolis\Desktop\iconos\descargar.jpg");
        }

        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            this.txtidarticulo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idarticulo"].Value);
            this.txtcodigo.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["codigo"].Value);
            this.txtnombre.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["nombre"].Value);
            this.txtdescripcion.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["descripcion"].Value);

            byte[] imagenbuffer = (byte[]) this.dataListado.CurrentRow.Cells["imagen"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenbuffer);
            this.pximagen.Image =  Image.FromStream(ms);
            this.pximagen.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtidcategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["idcategoria"].Value);
            this.txtcategoria.Text = Convert.ToString(this.dataListado.CurrentRow.Cells["Categoria"].Value);
            this.cbidpresentacion.SelectedValue = Convert.ToString(this.dataListado.CurrentRow.Cells["idpresentacion"].Value);


            this.tabControl1.SelectedIndex = 1;
        }

        private void cbidpresentacion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnbuscarcategoria_Click(object sender, EventArgs e)
        {
            frmvVistaCategoria_Articulo form = new frmvVistaCategoria_Articulo();
            form.ShowDialog();
        }
    }
}
