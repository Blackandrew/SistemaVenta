using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
   public class DPresentacion
    {
        private int _Idpresentacion;

        public int Idpresentacion
        {
            get { return _Idpresentacion; }
            set { _Idpresentacion = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Descripcion;

        public string Descripcion
        {
            get { return _Descripcion; }
            set { _Descripcion = value; }
        }
        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

       
      

        public DPresentacion()
        {

        }
        public DPresentacion(int idpresentacion,string nombre,string descripcion,string textobuscar)
        {
            this.Idpresentacion = idpresentacion;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = textobuscar;
        }

        //insertar
        public string Insertar(DPresentacion Presentacion)
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
                Sqlcmd.CommandText = "spinsertar_presentacion";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";//capturamos la variable del procedimiento
                ParIdpresentacion.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdpresentacion.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdpresentacion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Presentacion.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";//capturamos la variable del procedimiento
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Presentacion.Descripcion;
                Sqlcmd.Parameters.Add(ParDescripcion);

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
        public string Editar(DPresentacion Presentacion)
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
                Sqlcmd.CommandText = "speditar_presentacion";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";//capturamos la variable del procedimiento
                ParIdpresentacion.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdpresentacion.Value = Presentacion.Idpresentacion;
                Sqlcmd.Parameters.Add(ParIdpresentacion);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Presentacion.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";//capturamos la variable del procedimiento
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Presentacion.Nombre;
                Sqlcmd.Parameters.Add(ParDescripcion);

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

        public string Eliminar(DPresentacion Presentacion)
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
                Sqlcmd.CommandText = "speliminar_presentacion";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdpresentacion = new SqlParameter();
                ParIdpresentacion.ParameterName = "@idpresentacion";//capturamos la variable del procedimiento
                ParIdpresentacion.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdpresentacion.Value = Presentacion.Idpresentacion;
                Sqlcmd.Parameters.Add(ParIdpresentacion);


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
            DataTable DtResultado = new DataTable("presentacion");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_presentacion";
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

        public DataTable BuscarNombre(DPresentacion Presentacion)
        {
            DataTable DtResultado = new DataTable("presentacion");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_presentacion_nombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Presentacion.TextoBuscar;
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
