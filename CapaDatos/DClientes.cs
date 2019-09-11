using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
    
namespace CapaDatos
{
    public class DClientes
    {
        private int _Idcliente;

        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }
        private string _Nombre;

        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        private string _Apelidos;

        public string Apelidos
        {
            get { return _Apelidos; }
            set { _Apelidos = value; }
        }
        private string _Sexo;

        public string Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }
        private DateTime _Fecha_nacimiento;

        public DateTime Fecha_nacimiento
        {
            get { return _Fecha_nacimiento; }
            set { _Fecha_nacimiento = value; }
        }
        private string _Tipo_documento;

        public string Tipo_documento
        {
            get { return _Tipo_documento; }
            set { _Tipo_documento = value; }
        }
        private string _Num_Documento;

        public string Num_Documento
        {
            get { return _Num_Documento; }
            set { _Num_Documento = value; }
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
        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

       
        public DClientes() { }
        public DClientes(int idcliente,string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento,string num_documento,string direccion,string telefono,string email,string textobuscar) {
            this.Idcliente = idcliente;
            this.Nombre = nombre;
            this.Apelidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Tipo_documento = tipo_documento;
            this.Num_Documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.TextoBuscar = textobuscar;
        }

        //insertar
        public string Insertar(DClientes Cliente)
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
                Sqlcmd.CommandText = "psinsertar_cliente";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdclientes = new SqlParameter();
                ParIdclientes.ParameterName = "@idcliente";//capturamos la variable del procedimiento
                ParIdclientes.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdclientes.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdclientes);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);


                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";//capturamos la variable del procedimiento
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Cliente.Apelidos;
                Sqlcmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";//capturamos la variable del procedimiento
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Cliente.Sexo;
                Sqlcmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento = new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@fecha_nacimiento";//capturamos la variable del procedimiento
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Cliente.Fecha_nacimiento;
                Sqlcmd.Parameters.Add(ParFecha_nacimiento);


                SqlParameter Partipo_documento = new SqlParameter();
                Partipo_documento.ParameterName = "@tipo_documento";//capturamos la variable del procedimiento
                Partipo_documento.SqlDbType = SqlDbType.VarChar;
                Partipo_documento.Size = 50;
                Partipo_documento.Value = Cliente.Tipo_documento;
                Sqlcmd.Parameters.Add(Partipo_documento);

                SqlParameter Parnum_documento = new SqlParameter();
                Parnum_documento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                Parnum_documento.SqlDbType = SqlDbType.VarChar;
                Parnum_documento.Size = 50;
                Parnum_documento.Value = Cliente.Num_Documento;
                Sqlcmd.Parameters.Add(Parnum_documento);

                
                SqlParameter Pardireccion= new SqlParameter();
                Pardireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 50;
                Pardireccion.Value = Cliente.Direccion;
                Sqlcmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 50;
                Partelefono.Value = Cliente.Telefono;
                Sqlcmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = new SqlParameter();
                Paremail.ParameterName = "@email";//capturamos la variable del procedimiento
                Paremail.SqlDbType = SqlDbType.VarChar;
                Paremail.Size = 50;
                Paremail.Value = Cliente.Email;
                Sqlcmd.Parameters.Add(Paremail);

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
        public string Editar(DClientes Cliente)
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
                Sqlcmd.CommandText = "speditar_cliente";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";//capturamos la variable del procedimiento
                ParIdcliente.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcliente.Value = Cliente.Idcliente;
                Sqlcmd.Parameters.Add(ParIdcliente);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Cliente.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);


                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";//capturamos la variable del procedimiento
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Cliente.Apelidos;
                Sqlcmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";//capturamos la variable del procedimiento
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Cliente.Sexo;
                Sqlcmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento = new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@fecha_nacimiento";//capturamos la variable del procedimiento
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Cliente.Fecha_nacimiento;
                Sqlcmd.Parameters.Add(ParFecha_nacimiento);


                SqlParameter Partipo_documento = new SqlParameter();
                Partipo_documento.ParameterName = "@tipo_documento";//capturamos la variable del procedimiento
                Partipo_documento.SqlDbType = SqlDbType.VarChar;
                Partipo_documento.Size = 50;
                Partipo_documento.Value = Cliente.Tipo_documento;
                Sqlcmd.Parameters.Add(Partipo_documento);

                SqlParameter Parnum_documento = new SqlParameter();
                Parnum_documento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                Parnum_documento.SqlDbType = SqlDbType.VarChar;
                Parnum_documento.Size = 50;
                Parnum_documento.Value = Cliente.Num_Documento;
                Sqlcmd.Parameters.Add(Parnum_documento);


                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 50;
                Pardireccion.Value = Cliente.Direccion;
                Sqlcmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 50;
                Partelefono.Value = Cliente.Telefono;
                Sqlcmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = new SqlParameter();
                Paremail.ParameterName = "@email";//capturamos la variable del procedimiento
                Paremail.SqlDbType = SqlDbType.VarChar;
                Paremail.Size = 50;
                Paremail.Value = Cliente.Email;
                Sqlcmd.Parameters.Add(Paremail);

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

        public string Eliminar(DClientes Cliente)
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
                Sqlcmd.CommandText = "speliminar_cliente";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idcliente";//capturamos la variable del procedimiento
                ParIdcliente.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcliente.Value = Cliente.Idcliente;
                Sqlcmd.Parameters.Add(ParIdcliente);


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
            DataTable DtResultado = new DataTable("cliente");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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

        public DataTable BuscarClientes_Apellido(DClientes Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarclientes_apellido";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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

        public DataTable Buscarcliente_num_documento(DClientes Cliente)
        {
            DataTable DtResultado = new DataTable("cliente");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarcliente_num_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
