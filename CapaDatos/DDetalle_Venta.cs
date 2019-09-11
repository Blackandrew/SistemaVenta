using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class DDetalle_Venta
    {
        //encapsular ctr+r ,ctr+e
        private int _Iddetalle_venta;

        public int Iddetalle_venta
        {
            get { return _Iddetalle_venta; }
            set { _Iddetalle_venta = value; }
        }
        private int _Idventa;

        public int Idventa
        {
            get { return _Idventa; }
            set { _Idventa = value; }
        }
        private int _Iddetalle_ingreso;

        public int Iddetalle_ingreso
        {
            get { return _Iddetalle_ingreso; }
            set { _Iddetalle_ingreso = value; }
        }
        private int _Cantidad;

        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }
        private decimal _Precio_venta;

        public decimal Precio_venta
        {
            get { return _Precio_venta; }
            set { _Precio_venta = value; }
        }
        private decimal _Descuento;

        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

       

        public DDetalle_Venta()
        {

        }

        public DDetalle_Venta(int iddetalle_venta,int idventa,int iddetalle_ingreso,
                              int cantidad,decimal precio_venta,decimal descuento)
        {
            this.Iddetalle_venta = iddetalle_venta;
            this.Idventa = idventa;
            this._Iddetalle_ingreso = iddetalle_ingreso;
            this.Cantidad = cantidad;
            this.Precio_venta = precio_venta;
            this.Descuento = descuento;

         }


        //insertar
        public string Insertar(DDetalle_Venta Detalles_Venta,
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
                Sqlcmd.CommandText = "spinsertar_venta_detalle";//asignarle el nombre del procedimiento
                Sqlcmd.CommandType = CommandType.StoredProcedure;//decirle que tipo es la variable 

                //declaramos varibles de tipo sql

                SqlParameter ParIddetalles_venta = new SqlParameter();
                ParIddetalles_venta.ParameterName = "@iddetalle_venta";//capturamos la variable del procedimiento
                ParIddetalles_venta.SqlDbType = SqlDbType.Int;//le indicamos el tipo de dato
                ParIddetalles_venta.Direction = ParameterDirection.Output;//le indicamos que es una varible de salida
                Sqlcmd.Parameters.Add(ParIddetalles_venta);


                SqlParameter Paridventa = new SqlParameter();
                Paridventa.ParameterName = "@idventa";//capturamos la variable del procedimiento
                Paridventa.SqlDbType = SqlDbType.Int;
                Paridventa.Value = Detalles_Venta.Idventa ;
                Sqlcmd.Parameters.Add(Paridventa);

                SqlParameter Pariddetalle_ingreso = new SqlParameter();
                Pariddetalle_ingreso.ParameterName = "@iddetalle_ingreso";//capturamos la variable del procedimiento
                Pariddetalle_ingreso.SqlDbType = SqlDbType.Int;
                Pariddetalle_ingreso.Value = Detalles_Venta.Iddetalle_ingreso ;
                Sqlcmd.Parameters.Add(Pariddetalle_ingreso);

                SqlParameter ParCantidad = new SqlParameter();
                ParCantidad.ParameterName = "@cantidad";//capturamos la variable del procedimiento
                ParCantidad.SqlDbType = SqlDbType.Int;
                ParCantidad.Value = Detalles_Venta.Cantidad;
                Sqlcmd.Parameters.Add(ParCantidad);

                SqlParameter Parprecio_venta = new SqlParameter();
                Parprecio_venta.ParameterName = "@precio_venta";//capturamos la variable del procedimiento
                Parprecio_venta.SqlDbType = SqlDbType.Money;
                Parprecio_venta.Value = Detalles_Venta.Precio_venta;
                Sqlcmd.Parameters.Add(Parprecio_venta);

                SqlParameter ParDescuento = new SqlParameter();
                ParDescuento.ParameterName = "@descuento";//capturamos la variable del procedimiento
                ParDescuento.SqlDbType = SqlDbType.Money;
                ParDescuento.Value = Detalles_Venta.Descuento;
                Sqlcmd.Parameters.Add(ParDescuento);
                
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
