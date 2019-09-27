using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmPrincipal : Form
    {
        private int childFormNumber = 0;
        public string Idtrabajador = "";
        public string apellidos = "";
        public string nombre = "";
        public string acceso = "";


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
           //llamamos a la funcion para habilitar las ventanas segun el permiso de usuario
            Gesttion_usuarios();
        }

        private void articulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArticulo frm = frmArticulo._GetInstancia();//llamamos a la instancia de articulo
            frm.MdiParent = this;
            frm.Show();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmvVistaCategoria_Articulo frm = new frmvVistaCategoria_Articulo();
            frm.MdiParent = this;
            frm.Show();

        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void salirDelSistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void presentacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.MdiParent = this;//referencia al mismo formulario
            frm.Show();
        }

        private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProveedor frm = new FrmProveedor();
            frm.MdiParent = this; 
            frm.Show();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente frm = new frmCliente();
            frm.MdiParent = this;
            frm.Show();
        }

        private void trabajadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrabajador frm = new frmTrabajador();
            frm.MdiParent = this;
            frm.Show();//para que aparezca luego

        }
        //verificamos el permiso de los usuarios
        private void Gesttion_usuarios()
        {
            if (acceso.Equals ("Administrador"))
            {
                this.mnualmacen.Enabled = true;
                this.mnucompras.Enabled = true;
                this.mnuventas.Enabled = true;
                this.mnumantenimiento.Enabled = true;
                this.mnuconsulta.Enabled = true;
                this.mnuherramienta.Enabled = true;
                this.Tscompras.Enabled = true;
                this.Tsventas.Enabled = true;
            }
            else if (acceso.Equals("Vendedor"))
            {
                this.mnualmacen.Enabled = false;
                this.mnucompras.Enabled = false;
                this.mnuventas.Enabled = true;
                this.mnumantenimiento.Enabled = false;
                this.mnuconsulta.Enabled = true;
                this.mnuherramienta.Enabled = true;
                this.Tscompras.Enabled = false;
                this.Tsventas.Enabled = true;
            }
            else if (acceso.Equals("Almacenero"))
            {
                this.mnualmacen.Enabled = true;
                this.mnucompras.Enabled = true;
                this.mnuventas.Enabled = false;
                this.mnumantenimiento.Enabled = false;
                this.mnuconsulta.Enabled = true;
                this.mnuherramienta.Enabled = true;
                this.Tscompras.Enabled = true;
                this.Tsventas.Enabled = false;
            }
            else
            {
                this.mnualmacen.Enabled = false;
                this.mnucompras.Enabled = false;
                this.mnuventas.Enabled = false;
                this.mnumantenimiento.Enabled = false;
                this.mnuconsulta.Enabled = false;
                this.mnuherramienta.Enabled = false;
                this.Tscompras.Enabled = false;
                this.Tsventas.Enabled = false;
            }
        }

        private void toolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIngresos frm = FrmIngresos.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.id_trabajador =  Convert.ToInt32( this.Idtrabajador);
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmVenta frm = FrmVenta.GetInstancia();
            frm.MdiParent = this;
            frm.Show();
            frm.Idtrabajador = Convert.ToInt32(this.Idtrabajador);
        }

        private void stockDeArtículosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStock_articulos frm = new frmStock_articulos();
            frm.MdiParent = this;
            frm.Show();
        }
    }
}
