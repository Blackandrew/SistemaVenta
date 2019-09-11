using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;

using CapaDatos;

namespace CapaNegocio
{
   public class NVenta
    {
        public static string Insertar(int idcliente, int idtrabajador, DateTime fecha, string tipo_comprobante, string serie, string correlativo, decimal igv,  DataTable dtDetalles)
        {
            DVenta Obj = new DVenta();
            Obj.Idcliente = idcliente;
            Obj.Idtrabajador = idtrabajador;
            Obj.Fecha = fecha;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
          
            List<DDetalle_Venta> detalles = new List<DDetalle_Venta>();

            foreach (DataRow row in dtDetalles.Rows)//RECORRE EL DETALLE

            {
                //campos de la tabla a la cual recorre el ciclo
                DDetalle_Venta detalle = new DDetalle_Venta();
                detalle.Iddetalle_ingreso = Convert.ToInt32(row["iddetalle_ingreso"].ToString());
                detalle.Cantidad = Convert.ToInt32(row["cantidad"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Descuento = Convert.ToDecimal(row["descuento"].ToString());
                
                detalles.Add(detalle);
            }

            return Obj.Insertar(Obj, detalles);
        }
        public static string Eliminar(int idventa)
        {
            DVenta Obj = new DVenta();

            Obj.Idventa = idventa;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DVenta().Mostrar();
        }


        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            DVenta Obj = new DVenta();

            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }

        public static DataTable MostrarDetalles(string textobuscar)
        {
            DVenta Obj = new DVenta();

            return Obj.MostrarDetalles(textobuscar);
        }

        public static DataTable mostrararticulo_venta_nombre(string textobuscar)
        {
            DVenta Obj = new DVenta();

            return Obj.mostrararticulo_venta_nombre(textobuscar);
        }

        public static DataTable mostrararticulo_venta_codigo(string textobuscar)
        {
            DVenta Obj = new DVenta();

            return Obj.mostrararticulo_venta_codigo(textobuscar);
        }
    }
}
