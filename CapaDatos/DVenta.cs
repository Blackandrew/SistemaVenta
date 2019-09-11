using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class DVenta
    {
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
        private int _Idcliente;

        public int Idcliente
        {
            get { return _Idcliente; }
            set { _Idcliente = value; }
        }
        private int _Idtrabajador;

        public int Idtrabajador
        {
            get { return _Idtrabajador; }
            set { _Idtrabajador = value; }
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

       

        public DVenta()
        {

        }

        public DVenta(int idventa,int idcliente,int idtrabajador,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv)
        {
            this.Idventa = idventa;
            this.Idcliente = idcliente;
            this.Idtrabajador = idtrabajador;
            this.Fecha = fecha;
            this.Tipo_comprobante = tipo_comprobante;
            this.Serie = serie;
            this.Correlativo = correlativo;
            this.Igv = igv;
        }

        //metodo ANULAR

        public string Disminuir_stock(int iddetalle_ingreso,int cantidad)
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
                Sqlcmd.CommandText = "spdisminuir_stock";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter Pariddetalle_ingreso = new SqlParameter();
                Pariddetalle_ingreso.ParameterName = "@iddetalle_ingreso";//capturamos la variable del procedimiento
                Pariddetalle_ingreso.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                Pariddetalle_ingreso.Value = iddetalle_ingreso;
                Sqlcmd.Parameters.Add(Pariddetalle_ingreso);


                SqlParameter Parcantidad = new SqlParameter();
                Parcantidad.ParameterName = "@cantidad";//capturamos la variable del procedimiento
                Parcantidad.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                Parcantidad.Value = iddetalle_ingreso;
                Sqlcmd.Parameters.Add(Parcantidad);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se actualizo el stock";

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


        //insertar ventas

        public string Insertar(DVenta Venta, List<DDetalle_Venta> Detalle)
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
                Sqlcmd.CommandText = "spinsert_venta";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";//capturamos la variable del procedimiento
                ParIdventa.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdventa.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIdventa);

                SqlParameter Paridcliente = new SqlParameter();
                Paridcliente.ParameterName = "@idcliente";//capturamos la variable del procedimiento
                Paridcliente.SqlDbType = SqlDbType.Int;
                Paridcliente.Value = Venta.Idcliente;
                Sqlcmd.Parameters.Add(Paridcliente);

                SqlParameter Paridtrabajador = new SqlParameter();
                Paridtrabajador.ParameterName = "@idtrabajador";//capturamos la variable del procedimiento
                Paridtrabajador.SqlDbType = SqlDbType.Int;
                Paridtrabajador.Value = Venta.Idtrabajador;
                Sqlcmd.Parameters.Add(Paridtrabajador);

                SqlParameter PariFecha = new SqlParameter();
                PariFecha.ParameterName = "@fecha";//capturamos la variable del procedimiento
                PariFecha.SqlDbType = SqlDbType.Date;
                PariFecha.Value = Venta.Fecha;
                Sqlcmd.Parameters.Add(PariFecha);

                SqlParameter ParTipo_comprobante = new SqlParameter();
                ParTipo_comprobante.ParameterName = "@tipo_comprobante";//capturamos la variable del procedimiento
                ParTipo_comprobante.SqlDbType = SqlDbType.VarChar;
                ParTipo_comprobante.Size = 256;
                ParTipo_comprobante.Value = Venta.Tipo_comprobante;
                Sqlcmd.Parameters.Add(ParTipo_comprobante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";//capturamos la variable del procedimiento
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 5;
                ParSerie.Value = Venta.Serie;
                Sqlcmd.Parameters.Add(ParSerie);


                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";//capturamos la variable del procedimiento
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Venta.Correlativo;
                Sqlcmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParIgv = new SqlParameter();
                ParIgv.ParameterName = "@igv";//capturamos la variable del procedimiento
                ParIgv.SqlDbType = SqlDbType.Decimal;
                ParIgv.Precision = 4;
                ParIgv.Scale = 2;
                ParIgv.Value = Venta.Igv;
                Sqlcmd.Parameters.Add(ParIgv);

              

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso El Registro";

                //obtener el codigo de venta generado
                if (rpta.Equals("OK"))
                {
                    //OBTENER EL CODIGO DE INGRESO
                    this.Idventa = Convert.ToInt32(Sqlcmd.Parameters["@idventa"].Value);
                    foreach (DDetalle_Venta det in Detalle)
                    {
                        det.Idventa = this.Idventa;
                        //llamar al metodo insetar

                        rpta = det.Insertar(det, ref SqlCon, ref SqlTra);

                        if (!rpta.Equals("OK"))
                        {
                           
                            break;
                        }
                        else
                        {
                            rpta = Disminuir_stock(det.Iddetalle_ingreso, det.Cantidad);
                            if (!rpta.Equals("OK"))
                            {

                                break;
                            }
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
                rpta = e.Message + "prueba";
            }

            finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }

            return rpta;
        }


        //eliminar
        public string Eliminar(DVenta Venta)
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
                Sqlcmd.CommandText = "speliminar_venta";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIdventa = new SqlParameter();
                ParIdventa.ParameterName = "@idventa";//capturamos la variable del procedimiento
                ParIdventa.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIdventa.Value = Venta.Idventa ;
                Sqlcmd.Parameters.Add(ParIdventa);


                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "Ok";

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
            DataTable DtResultado = new DataTable("venta");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_ventas";
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

        public DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DataTable DtResultado = new DataTable("venta");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venta_fecha";
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
            DataTable DtResultado = new DataTable("detalle_venta");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_venta";
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

        //mostrar los articulo por el nombre
        public DataTable mostrararticulo_venta_nombre(string textobuscar)
        {
            DataTable DtResultado = new DataTable("articulo");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_nombre";
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
        //mostrara articulo por codigo
        public DataTable mostrararticulo_venta_codigo(string textobuscar)
        {
            DataTable DtResultado = new DataTable("articulo");//intancia de tipo datatable pasandole como prarametro la tabla
            SqlConnection SqlCon = new SqlConnection();

            try
            {
                SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscararticulo_venta_codigo";
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
