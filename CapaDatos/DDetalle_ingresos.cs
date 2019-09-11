using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalle_ingresos
    {//variables

        private int _Iddetalle_ingreso;

        public int Iddetalle_ingreso
        {
            get { return _Iddetalle_ingreso; }
            set { _Iddetalle_ingreso = value; }
        }
        private int _Idingreso;

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }
        private int _Idarticulo;

        public int Idarticulo
        {
            get { return _Idarticulo; }
            set { _Idarticulo = value; }
        }
        private decimal _Precio_compra;

        public decimal Precio_compra
        {
            get { return _Precio_compra; }
            set { _Precio_compra = value; }
        }
        private decimal _Precio_venta;

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }
        private int _Stock_inicial;

        public int Stock_inicial
        {
            get { return _Stock_inicial; }
            set { _Stock_inicial = value; }
        }
        private int _Stock_actual;

        public int Stock_actual
        {
            get { return _Stock_actual; }
            set { _Stock_actual = value; }
        }
        private DateTime _Fecha_procuccion;

        public DateTime Fecha_procuccion
        {
            get { return _Fecha_procuccion; }
            set { _Fecha_procuccion = value; }
        }
        private DateTime _Fecha_vencimiento;

        public DateTime Fecha_vencimiento
        {
            get { return _Fecha_vencimiento; }
            set { _Fecha_vencimiento = value; }
        }
        //para encapsular rapido es ctr+r luego ctr+e

        


        public DDetalle_ingresos()
        {

        }

        public DDetalle_ingresos(int iddetalle_ingreso,int idingreso,int idarticulo,decimal precio_compra,decimal precio_venta,
                                     int stock_inicial,int stock_actual,
                                     DateTime fecha_produccion,DateTime fecha_vencimiento)
        {
            this.Iddetalle_ingreso = _Iddetalle_ingreso;
            this.Idingreso = idingreso;
            this.Idarticulo = idarticulo;
            this.Precio_compra = precio_compra;
            this.Precio_venta = precio_venta;
            this.Stock_inicial = Stock_inicial;
            this._Stock_actual = stock_actual;
            this.Fecha_procuccion = fecha_produccion;
            this.Fecha_vencimiento = fecha_vencimiento;
           
        }


        //insertar
        public string Insertar(DDetalle_ingresos Detalles_ingresos,
            ref SqlConnection SqlCon,
            ref SqlTransaction SqlTra)
            //recibe la conexion atraves de referencia y la transaccion 
            //unico ingreso 
        {
           
            string rpta = "";
                      
            try
            {
               // SqlCon.ConnectionString = Conexion.Cn;
                //SqlCon.Open();
                //establecemos comandos
                SqlCommand Sqlcmd = new SqlCommand();
                Sqlcmd.Connection = SqlCon;
                Sqlcmd.Transaction = SqlTra;
                Sqlcmd.CommandText = "spinsertar_detalle_ingrese";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIddetalles_ingresos = new SqlParameter();
                ParIddetalles_ingresos.ParameterName = "@iddetalle_ingreso";//capturamos la variable del procedimiento
                ParIddetalles_ingresos.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIddetalles_ingresos.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIddetalles_ingresos);
                               

                SqlParameter Paridingreso = new SqlParameter();
                Paridingreso.ParameterName = "@idingreso";//capturamos la variable del procedimiento
                Paridingreso.SqlDbType = SqlDbType.Int;
                Paridingreso.Value = Detalles_ingresos.Idingreso;
                Sqlcmd.Parameters.Add(Paridingreso);

                SqlParameter Paridarticulo = new SqlParameter();
                Paridarticulo.ParameterName = "@idarticulo";//capturamos la variable del procedimiento
                Paridarticulo.SqlDbType = SqlDbType.Int;
                Paridarticulo.Value = Detalles_ingresos.Idarticulo;
                Sqlcmd.Parameters.Add(Paridarticulo);

                SqlParameter Parprecio_compra = new SqlParameter();
                Parprecio_compra.ParameterName = "@precio_compra";//capturamos la variable del procedimiento
                Parprecio_compra.SqlDbType = SqlDbType.Money;
                Parprecio_compra.Value = Detalles_ingresos.Precio_compra;
                Sqlcmd.Parameters.Add(Parprecio_compra);

                SqlParameter Parprecio_venta = new SqlParameter();
                Parprecio_venta.ParameterName = "@precio_venta";//capturamos la variable del procedimiento
                Parprecio_venta.SqlDbType = SqlDbType.Money;
                Parprecio_venta.Value = Detalles_ingresos.Precio_venta;
                Sqlcmd.Parameters.Add(Parprecio_venta);

                SqlParameter Parstock_inicial = new SqlParameter();
                Parstock_inicial.ParameterName = "@stock_inicial";//capturamos la variable del procedimiento
                Parstock_inicial.SqlDbType = SqlDbType.Int;
                Parstock_inicial.Value = Detalles_ingresos.Stock_inicial;
                Sqlcmd.Parameters.Add(Parstock_inicial);

                SqlParameter Parstock_actual = new SqlParameter();
                Parstock_actual.ParameterName = "@stock_actual";//capturamos la variable del procedimiento
                Parstock_actual.SqlDbType = SqlDbType.Int;
                Parstock_actual.Value = Detalles_ingresos.Stock_actual;
                Sqlcmd.Parameters.Add(Parstock_actual);

                SqlParameter ParFecha_produccion = new SqlParameter();
                ParFecha_produccion.ParameterName = "@fecha_produccion";//capturamos la variable del procedimiento
                ParFecha_produccion.SqlDbType = SqlDbType.DateTime;
                ParFecha_produccion.Value = Detalles_ingresos.Fecha_procuccion;
                Sqlcmd.Parameters.Add(ParFecha_produccion);


                SqlParameter ParFecha_vencimiento = new SqlParameter();
                ParFecha_vencimiento.ParameterName = "@fecha_vencimiento";//capturamos la variable del procedimiento
                ParFecha_vencimiento.SqlDbType = SqlDbType.DateTime;
                 ParFecha_vencimiento.Value = Detalles_ingresos.Fecha_vencimiento;
                Sqlcmd.Parameters.Add(ParFecha_vencimiento);

                rpta = Sqlcmd.ExecuteNonQuery() == 1 ? "OK" : "No se Ingreso El Registro";

            }
            catch (Exception e)
            {
                rpta = e.Message;
            }
          /* finally
            {
                //cerramos conexion 
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }*/

            return rpta;
        }

             




    }
}
