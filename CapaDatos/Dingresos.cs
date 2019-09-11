using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using System.Windows.Forms;

namespace CapaDatos
{
    public class Dingresos
    {
        //variables
        private int _Idingreso;

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }
        private int _Idtrabajador;

        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
        }
        private int _Idproveerdor;

        public int Idproveerdor
        {
            get { return _Idproveerdor; }
            set { _Idproveerdor = value; }
        }
        private DateTime _Fecha;

        public DateTime Fecha
        {
            get { return _Fecha; }
            set { _Fecha = value; }
        }
        private string _Tipo_comprobante;

        public string Tipo_comprobante
        {
            get { return _Tipo_comprobante; }
            set { _Tipo_comprobante = value; }
        }
        private string _Serie;

        public string Serie
        {
            get { return _Serie; }
            set { _Serie = value; }
        }
        private string _Correlativo;

        public string Correlativo
        {
            get { return _Correlativo; }
            set { _Correlativo = value; }
        }
        private decimal _Igv;

        public decimal Igv
        {
            get { return _Igv; }
            set { _Igv = value; }
        }
        private string _Estado;

        public string Estado
        {
            get { return _Estado; }
            set { _Estado = value; }
        }

       

        public Dingresos() { }

        public Dingresos(int idngreso,int idtrabajador,int idproveedor,DateTime fecha,
            string tipo_comprobante,string serie,string correlativo,decimal igv,string estado ) {

            this.Idingreso = idngreso;
            this.Idtrabajador = idtrabajador;
            this.Idproveerdor = idproveedor;
            this.Fecha = fecha;
            this.Tipo_comprobante=tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
            this.Estado = estado;

        }

        //insertar ingresos

        public string Insertar(Dingresos Ingresos, List<DDetalle_ingresos> Detalle)
        {
            string rpta = "";

            SqlConnection SqlCon = new SqlConnection();
            try
            {
                               
               SqlCon.ConnectionString = Conexion.Cn;
                SqlCon.Open();
                //estableceremos una transaccion
                SqlTransaction SqlTra = SqlCon.BeginTransaction();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.Transaction = SqlTra;
                Sqlcmd.CommandText = "spinsertar_ingreso";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";//capturamos la variable del procedimiento
                ParIdingreso.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdingreso.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdingreso);

                SqlParameter Paridtrabajador = new SqlParameter();
                Paridtrabajador.ParameterName = "@idtrabajador";//capturamos la variable del procedimiento
                Paridtrabajador.SqlDbType = SqlDbType.Int;
                Paridtrabajador.Value = Ingresos.Idtrabajador;
                Sqlcmd.Parameters.Add(Paridtrabajador);

                SqlParameter Paridproveedor = new SqlParameter();
                Paridproveedor.ParameterName = "@idproveedor";//capturamos la variable del procedimiento
                Paridproveedor.SqlDbType = SqlDbType.Int;
                Paridproveedor.Value = Ingresos.Idproveerdor;
                Sqlcmd.Parameters.Add(Paridproveedor);

                SqlParameter PariFecha = new SqlParameter();
                PariFecha.ParameterName = "@fecha";//capturamos la variable del procedimiento
                PariFecha.SqlDbType = SqlDbType.Date;
                PariFecha.Value = Ingresos.Fecha;
                Sqlcmd.Parameters.Add(PariFecha);

                SqlParameter ParTipo_comprobante = new SqlParameter();
                ParTipo_comprobante.ParameterName = "@tipo_comprobante";//capturamos la variable del procedimiento
                ParTipo_comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_comprobante.Size = 256;
                ParTipo_comprobante.Value = Ingresos.Tipo_comprobante;
                Sqlcmd.Parameters.Add(ParTipo_comprobante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";//capturamos la variable del procedimiento
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 5;
                ParSerie.Value = Ingresos.Serie;
                Sqlcmd.Parameters.Add(ParSerie);


                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";//capturamos la variable del procedimiento
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Ingresos.Correlativo;
                Sqlcmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParIgv = new SqlParameter();
                ParIgv.ParameterName = "@igv";//capturamos la variable del procedimiento
                ParIgv.SqlDbType = SqlDbType.Decimal;
                ParIgv.Precision = 4;
                ParIgv.Scale = 2;
                ParIgv.Value = Ingresos.Igv;
                Sqlcmd.Parameters.Add(ParIgv);

                SqlParameter Parestado = new SqlParameter();
                Parestado.ParameterName = "@estado";//capturamos la variable del procedimiento
                Parestado.SqlDbType = SqlDbType.VarChar;
                Parestado.Size = 7;
                Parestado.Value = Ingresos.Estado;
                Sqlcmd.Parameters.Add(Parestado);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso El Registro";

                //obtener el codigo de ingreso generado
                if (rpta.Equals("OK"))
                {
                    //OBTENER EL CODIGO DE INGRESO
                    this.Idingreso = Convert.ToInt32(Sqlcmd.Parameters["@idingreso"].Value);
                    foreach (DDetalle_ingresos det in Detalle)
                    {
                        det.Idingreso = this.Idingreso;
                        //llamar al metodo insetar
                       
                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);

                        if (!rpta.Equals("OK"))
                        {
                            MessageBox.Show("marlon",
                            "Mensaje importante");
                            break;
                        }
                    }

                }
                if (rpta.Equals("OK"))
                {
                    SqlTra.Commit();
                }
                else
                {
                    SqlTra.Rollback();
                }

            }
            catch (Exception e)
            {
                rpta = e.Message+"prueba";
            }
        
          finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }

        //metodo ANULAR

        public string Anular(Dingresos Ingresos)
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
                Sqlcmd.CommandText = "spanular_ingreso";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";//capturamos la variable del procedimiento
                ParIdingreso.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdingreso.Value = Ingresos.Idingreso;
                Sqlcmd.Parameters.Add(ParIdingreso);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Anuló el Registro";

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
            DataTable DtResultado = new DataTable("ingreso");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ingreso";
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

        public DataTable BuscarFechas(string textobuscar,string textobuscar2)
        {
            DataTable DtResultado = new DataTable("ingreso");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_ingreso_fecha";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = textobuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);


                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);


            }
            catch (Exception e)
            {
                DtResultado = null;
            }
            return DtResultado;
        }


        public DataTable MostrarDetalles(string textobuscar)
        {
            DataTable DtResultado = new DataTable("detalle_ingreso");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
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
