using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class DCategoria
    {

        private int _Idcategoria;

        public int Idcategoria
        {
            get { return _Idcategoria; }
            set { _Idcategoria = value; }
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

        public DCategoria()
        {

        }

        public DCategoria(int idcategoria, string nombre, string descripcion,string texto)
        {
            this.Idcategoria = idcategoria;
            this.Nombre = nombre;
            this.Descripcion = descripcion;
            this.TextoBuscar = texto;
        }

        //metodo insertar

        public string Insertar(DCategoria  Categoria)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try{
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.CommandText = "spinsertar_categoria";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";//capturamos la variable del procedimiento
                ParIdcategoria.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcategoria.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";//capturamos la variable del procedimiento
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Descripcion;
                Sqlcmd.Parameters.Add(ParDescripcion);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso El Registro";
                    
            }
            catch(Exception e)
            {
                rpta = e.Message;
            }

            finally{
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }


        //metodo editar
        public string Editar(DCategoria Categoria)
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
                Sqlcmd.CommandText = "speditar_categoria";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";//capturamos la variable del procedimiento
                ParIdcategoria.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcategoria.Value = Categoria.Idcategoria;
                Sqlcmd.Parameters.Add(ParIdcategoria);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Categoria.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);

                SqlParameter ParDescripcion = new SqlParameter();
                ParDescripcion.ParameterName = "@descripcion";//capturamos la variable del procedimiento
                ParDescripcion.SqlDbType = SqlDbType.VarChar;
                ParDescripcion.Size = 256;
                ParDescripcion.Value = Categoria.Nombre;
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

        public string Eliminar(DCategoria Categoria)
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
                Sqlcmd.CommandText = "speliminar_categoria";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdcategoria = new SqlParameter();
                ParIdcategoria.ParameterName = "@idcategoria";//capturamos la variable del procedimiento
                ParIdcategoria.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcategoria.Value = Categoria.Idcategoria;
                Sqlcmd.Parameters.Add(ParIdcategoria);

               
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
            DataTable DtResultado = new DataTable("categoria");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_categoria";
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

        public DataTable BuscarNombre(DCategoria Categoria)
        {
            DataTable DtResultado = new DataTable("categoria");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_categoria";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Categoria.TextoBuscar;
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
