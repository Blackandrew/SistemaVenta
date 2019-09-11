using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CapaDatos
{
    public class DProveedor
    {
        //declaracion de variable
        private int _Idproveedor;

        public int Idproveedor
        {
            get { return _Idproveedor; }
            set { _Idproveedor = value; }
        }
        private string _RazonSocial;

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
        private string _SectorComercial;

        public string SectorComercial
        {
            get { return _SectorComercial; }
            set { _SectorComercial = value; }
        }
        private string _TipoDocumento;

        public string TipoDocumento
        {
            get { return _TipoDocumento; }
            set { _TipoDocumento = value; }
        }
        private string _NumDocumento;

        public string NumDocumento
        {
            get { return _NumDocumento; }
            set { _NumDocumento = value; }
        }
        private string _Direccion;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }
        }
        private string _Telefono;

        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }
        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        private string _Url;

        public string Url
        {
            get { return _Url; }
            set { _Url = value; }
        }
        private string _textoBuscar;

        public string TextoBuscar
        {
            get { return _textoBuscar; }
            set { _textoBuscar = value; }
        }

      

        public DProveedor() { }

        public DProveedor(int idproveedor,string razonsocial,string sectorcomercial,string tipodocumento,string numdocumento,string direccion,string telefono,string email,string url,string textobuscar)
        {
            this.Idproveedor = idproveedor;
            this.RazonSocial = razonsocial;
            this.SectorComercial = sectorcomercial;
            this.TipoDocumento = tipodocumento;
            this.NumDocumento = numdocumento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Url = url;
            this.TextoBuscar = textobuscar;
        }

        //metodo insertar

        public string Insertar(DProveedor Proveedor)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "spinsertar_proveedor";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";//capturamos la variable del procedimiento
                ParIdproveedor.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdproveedor.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParRazonsocial = new SqlParameter();
                ParRazonsocial.ParameterName = "@razon_social";//capturamos la variable del procedimiento
                ParRazonsocial.SqlDbType = SqlDbType.VarChar;
                ParRazonsocial.Size = 150;
                ParRazonsocial.Value = Proveedor.RazonSocial;
                Sqlcmd.Parameters.Add(ParRazonsocial);

                SqlParameter ParSectorcomercial = new SqlParameter();
                ParSectorcomercial.ParameterName = "@sector_comercial";//capturamos la variable del procedimiento
                ParSectorcomercial.SqlDbType = SqlDbType.VarChar;
                ParSectorcomercial.Size = 50;
                ParSectorcomercial.Value = Proveedor.SectorComercial;
                Sqlcmd.Parameters.Add(ParSectorcomercial);

                SqlParameter ParTipodocumento = new SqlParameter();
                ParTipodocumento.ParameterName = "@tipo_documento";//capturamos la variable del procedimiento
                ParTipodocumento.SqlDbType = SqlDbType.VarChar;
                ParTipodocumento.Size = 20;
                ParTipodocumento.Value = Proveedor.TipoDocumento;
                Sqlcmd.Parameters.Add(ParTipodocumento);

                SqlParameter ParNumdocumento = new SqlParameter();
                ParNumdocumento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                ParNumdocumento.SqlDbType = SqlDbType.VarChar;
                ParNumdocumento.Size = 11;
                ParNumdocumento.Value = Proveedor.NumDocumento;
                Sqlcmd.Parameters.Add(ParNumdocumento);
                
                SqlParameter ParDireccion= new SqlParameter();
                ParDireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                Sqlcmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 100;
                ParTelefono.Value = Proveedor.Telefono;
                Sqlcmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";//capturamos la variable del procedimiento
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 100;
                ParEmail.Value = Proveedor.Email;
                Sqlcmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";//capturamos la variable del procedimiento
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                Sqlcmd.Parameters.Add(ParUrl);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso El Registro";

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }

            finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }


        //metodo editar
        public string Editar(DProveedor Proveedor)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "speditar_proveedor";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";//capturamos la variable del procedimiento
                ParIdproveedor.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdproveedor.Value = Proveedor.Idproveedor;
                Sqlcmd.Parameters.Add(ParIdproveedor);

                SqlParameter ParRazonsocial = new SqlParameter();
                ParRazonsocial.ParameterName = "@razon_social";//capturamos la variable del procedimiento
                ParRazonsocial.SqlDbType = SqlDbType.VarChar;
                ParRazonsocial.Size = 150;
                ParRazonsocial.Value = Proveedor.RazonSocial;
                Sqlcmd.Parameters.Add(ParRazonsocial);

                SqlParameter ParSectorcomercial = new SqlParameter();
                ParSectorcomercial.ParameterName = "@sector_comercial";//capturamos la variable del procedimiento
                ParSectorcomercial.SqlDbType = SqlDbType.VarChar;
                ParSectorcomercial.Size = 50;
                ParSectorcomercial.Value = Proveedor.SectorComercial;
                Sqlcmd.Parameters.Add(ParRazonsocial);

                SqlParameter ParTipodocumento = new SqlParameter();
                ParTipodocumento.ParameterName = "@tipo_documento";//capturamos la variable del procedimiento
                ParTipodocumento.SqlDbType = SqlDbType.VarChar;
                ParTipodocumento.Size = 20;
                ParTipodocumento.Value = Proveedor.TipoDocumento;
                Sqlcmd.Parameters.Add(ParTipodocumento);

                SqlParameter ParNumdocumento = new SqlParameter();
                ParNumdocumento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                ParNumdocumento.SqlDbType = SqlDbType.VarChar;
                ParNumdocumento.Size = 11;
                ParNumdocumento.Value = Proveedor.NumDocumento;
                Sqlcmd.Parameters.Add(ParNumdocumento);

                SqlParameter ParDireccion = new SqlParameter();
                ParDireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                ParDireccion.SqlDbType = SqlDbType.VarChar;
                ParDireccion.Size = 100;
                ParDireccion.Value = Proveedor.Direccion;
                Sqlcmd.Parameters.Add(ParDireccion);

                SqlParameter ParTelefono = new SqlParameter();
                ParTelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                ParTelefono.SqlDbType = SqlDbType.VarChar;
                ParTelefono.Size = 0;
                ParTelefono.Value = Proveedor.Telefono;
                Sqlcmd.Parameters.Add(ParTelefono);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";//capturamos la variable del procedimiento
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = Proveedor.Email;
                Sqlcmd.Parameters.Add(ParEmail);

                SqlParameter ParUrl = new SqlParameter();
                ParUrl.ParameterName = "@url";//capturamos la variable del procedimiento
                ParUrl.SqlDbType = SqlDbType.VarChar;
                ParUrl.Size = 100;
                ParUrl.Value = Proveedor.Url;
                Sqlcmd.Parameters.Add(ParUrl);
                
                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Actualizó el Registro";

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }

            finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo eliminar

        public string Eliminar(DProveedor Proveedor)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "speliminar_proveedor";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdproveedor = new SqlParameter();
                ParIdproveedor.ParameterName = "@idproveedor";//capturamos la variable del procedimiento
                ParIdproveedor.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdproveedor.Value = Proveedor.Idproveedor;
                Sqlcmd.Parameters.Add(ParIdproveedor);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Eliminó el Registro";

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }

            finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo mostrar registros

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("proveedor");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_proveedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);


            }
            catch (Exception e)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable BuscarRazon_Social(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_razon_social";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);


            }
            catch (Exception e)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable BuscarNum_Documento(DProveedor Proveedor)
        {
            DataTable DtResultado = new DataTable("proveedor");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_proveedor_num_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Proveedor.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception e)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

    }


}
