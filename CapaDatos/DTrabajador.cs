using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DTrabajador
    {
        private int _Idtrabajador;

        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
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
        private string _Acceso;

        public string Acceso
        {
            get { return _Acceso; }
            set { _Acceso = value; }
        }
        private string _Usuario;

        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }
        private string _Password;

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        private string _TextoBuscar;

        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

    

        public DTrabajador() { }
        //se crea el constructor
        public DTrabajador(int idtrabajador, string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email,string acceso, string usuario, string password, string textobuscar)
        {
            this.Idtrabajador = idtrabajador;
            this.Nombre = nombre;
            this.Apelidos = apellidos;
            this.Sexo = sexo;
            this.Fecha_nacimiento = fecha_nacimiento;
            this.Num_Documento = num_documento;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Email = email;
            this.Acceso = acceso;
            this.Usuario = usuario;
            this.Password = password;
            this.TextoBuscar = textobuscar;
        }

        //insertar
        public string Insertar(DTrabajador Trabajador)
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
                Sqlcmd.CommandText = "psinsertar_trabajador";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";//capturamos la variable del procedimiento
                ParIdtrabajador.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdtrabajador.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdtrabajador);

                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Trabajador.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);


                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";//capturamos la variable del procedimiento
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Trabajador.Apelidos;
                Sqlcmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";//capturamos la variable del procedimiento
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Trabajador.Sexo;
                Sqlcmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento = new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@fecha_nac";//capturamos la variable del procedimiento
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Trabajador.Fecha_nacimiento;
                Sqlcmd.Parameters.Add(ParFecha_nacimiento);


                SqlParameter Parnum_documento = new SqlParameter();
                Parnum_documento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                Parnum_documento.SqlDbType = SqlDbType.VarChar;
                Parnum_documento.Size = 50;
                Parnum_documento.Value = Trabajador.Num_Documento;
                Sqlcmd.Parameters.Add(Parnum_documento);


                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 50;
                Pardireccion.Value = Trabajador.Direccion;
                Sqlcmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 50;
                Partelefono.Value = Trabajador.Telefono;
                Sqlcmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = new SqlParameter();
                Paremail.ParameterName = "@email";//capturamos la variable del procedimiento
                Paremail.SqlDbType = SqlDbType.VarChar;
                Paremail.Size = 50;
                Paremail.Value = Trabajador.Email;
                Sqlcmd.Parameters.Add(Paremail);

                SqlParameter Paracceso = new SqlParameter();
                Paracceso.ParameterName = "@acceso";//capturamos la variable del procedimiento
                Paracceso.SqlDbType = SqlDbType.VarChar;
                Paracceso.Size = 50;
                Paracceso.Value = Trabajador.Acceso;
                Sqlcmd.Parameters.Add(Paracceso);


                SqlParameter Parusuario = new SqlParameter();
                Parusuario.ParameterName = "@usuario";//capturamos la variable del procedimiento
                Parusuario.SqlDbType = SqlDbType.VarChar;
                Parusuario.Size = 50;
                Parusuario.Value = Trabajador.Usuario;
                Sqlcmd.Parameters.Add(Parusuario);


                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";//capturamos la variable del procedimiento
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Trabajador.Password;
                Sqlcmd.Parameters.Add(ParPassword);


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
        public string Editar(DTrabajador Trabajador)
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
                Sqlcmd.CommandText = "speditar_trabajador";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql
                SqlParameter ParIdtrabajador = new SqlParameter();
                ParIdtrabajador.ParameterName = "@idtrabajador";//capturamos la variable del procedimiento
                ParIdtrabajador.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdtrabajador.Value = Trabajador.Idtrabajador;
                Sqlcmd.Parameters.Add(ParIdtrabajador);



                SqlParameter ParNombre = new SqlParameter();
                ParNombre.ParameterName = "@nombre";//capturamos la variable del procedimiento
                ParNombre.SqlDbType = SqlDbType.VarChar;
                ParNombre.Size = 50;
                ParNombre.Value = Trabajador.Nombre;
                Sqlcmd.Parameters.Add(ParNombre);


                SqlParameter ParApellidos = new SqlParameter();
                ParApellidos.ParameterName = "@apellidos";//capturamos la variable del procedimiento
                ParApellidos.SqlDbType = SqlDbType.VarChar;
                ParApellidos.Size = 50;
                ParApellidos.Value = Trabajador.Apelidos;
                Sqlcmd.Parameters.Add(ParApellidos);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";//capturamos la variable del procedimiento
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 50;
                ParSexo.Value = Trabajador.Sexo;
                Sqlcmd.Parameters.Add(ParSexo);

                SqlParameter ParFecha_nacimiento = new SqlParameter();
                ParFecha_nacimiento.ParameterName = "@fecha_nac";//capturamos la variable del procedimiento
                ParFecha_nacimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_nacimiento.Size = 50;
                ParFecha_nacimiento.Value = Trabajador.Fecha_nacimiento;
                Sqlcmd.Parameters.Add(ParFecha_nacimiento);


                SqlParameter Parnum_documento = new SqlParameter();
                Parnum_documento.ParameterName = "@num_documento";//capturamos la variable del procedimiento
                Parnum_documento.SqlDbType = SqlDbType.VarChar;
                Parnum_documento.Size = 50;
                Parnum_documento.Value = Trabajador.Num_Documento;
                Sqlcmd.Parameters.Add(Parnum_documento);


                SqlParameter Pardireccion = new SqlParameter();
                Pardireccion.ParameterName = "@direccion";//capturamos la variable del procedimiento
                Pardireccion.SqlDbType = SqlDbType.VarChar;
                Pardireccion.Size = 50;
                Pardireccion.Value = Trabajador.Direccion;
                Sqlcmd.Parameters.Add(Pardireccion);

                SqlParameter Partelefono = new SqlParameter();
                Partelefono.ParameterName = "@telefono";//capturamos la variable del procedimiento
                Partelefono.SqlDbType = SqlDbType.VarChar;
                Partelefono.Size = 50;
                Partelefono.Value = Trabajador.Telefono;
                Sqlcmd.Parameters.Add(Partelefono);

                SqlParameter Paremail = new SqlParameter();
                Paremail.ParameterName = "@email";//capturamos la variable del procedimiento
                Paremail.SqlDbType = SqlDbType.VarChar;
                Paremail.Size = 50;
                Paremail.Value = Trabajador.Email;
                Sqlcmd.Parameters.Add(Paremail);

                SqlParameter Paracceso = new SqlParameter();
                Paracceso.ParameterName = "@acceso";//capturamos la variable del procedimiento
                Paracceso.SqlDbType = SqlDbType.VarChar;
                Paracceso.Size = 50;
                Paracceso.Value = Trabajador.Acceso;
                Sqlcmd.Parameters.Add(Paracceso);


                SqlParameter Parusuario = new SqlParameter();
                Parusuario.ParameterName = "@usuario";//capturamos la variable del procedimiento
                Parusuario.SqlDbType = SqlDbType.VarChar;
                Parusuario.Size = 50;
                Parusuario.Value = Trabajador.Usuario;
                Sqlcmd.Parameters.Add(Parusuario);


                SqlParameter ParPassword = new SqlParameter();
                ParPassword.ParameterName = "@password";//capturamos la variable del procedimiento
                ParPassword.SqlDbType = SqlDbType.VarChar;
                ParPassword.Size = 50;
                ParPassword.Value = Trabajador.Password;
                Sqlcmd.Parameters.Add(ParPassword);


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

        public string Eliminar(DTrabajador Trabajador)
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
                Sqlcmd.CommandText = "speliminar_trabajador";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                SqlParameter ParIdcliente = new SqlParameter();
                ParIdcliente.ParameterName = "@idtrabajador";//capturamos la variable del procedimiento
                ParIdcliente.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdcliente.Value = Trabajador.Idtrabajador;
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
            DataTable DtResultado = new DataTable("trabajador");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_trabajador";
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


        public DataTable Buscarapellido_trabajador(DTrabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("trabajador");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarapellido_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Trabajador.TextoBuscar;
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

        public DataTable Buscarnum_docu_trabajador(DTrabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("trabajador");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarnum_docu_trabajador";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Trabajador.TextoBuscar;
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

        public DataTable Login(DTrabajador Trabajador)
        {
            DataTable DtResultado = new DataTable("trabajador");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "sp_login";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 20;
                ParUsuario.Value = Trabajador.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter Parpass = new SqlParameter();
                Parpass.ParameterName = "@password";
                Parpass.SqlDbType = SqlDbType.VarChar;
                Parpass.Size = 20;
                Parpass.Value = Trabajador.Password;
                SqlCmd.Parameters.Add(Parpass);


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
