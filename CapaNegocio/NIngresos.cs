using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;

namespace CapaNegocio
{
    public class NIngresos
    {

        public static string Insertar(int idtrabajador,int idproveedor,DateTime fecha,string tipo_comprobante,string serie,string correlativo,decimal igv, string estado,DataTable dtDetalles)
        {
            Dingresos Obj = new  Dingresos();
            Obj.Idtrabajador = idtrabajador;
            Obj.Idproveerdor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            Obj.Estado = estado;
            List<DDetalle_ingresos> detalles = new List<DDetalle_ingresos>();

            foreach(DataRow row in dtDetalles.Rows)//RECORRE EL DETALLE
            {
                DDetalle_ingresos detalle = new DDetalle_ingresos();
                detalle.Idarticulo = Convert.ToInt32 ( row["idarticulo"].ToString());
                detalle.Precio_compra = Convert.ToDecimal (row["precio_compra"].ToString());
                detalle.Precio_venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_inicial = Convert.ToInt32 (row["stock_inicial"].ToString());
                detalle.Stock_actual = Convert.ToInt32(row["stock_actual"].ToString());
                detalle.Fecha_procuccion = Convert.ToDateTime (row["fecha_produccion"].ToString());
                detalle.Fecha_vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }

            return Obj.Insertar(Obj,detalles);
        }
        public static string Anular(int idingresos)
        {
            Dingresos Obj = new Dingresos();

            Obj.Idingreso = idingresos;

            return Obj.Anular(Obj);
        }

        public static DataTable Mostrar()
        {
            return new Dingresos().Mostrar();
        }


        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            Dingresos Obj = new Dingresos();
         
            return Obj.BuscarFechas(textobuscar,textobuscar2);
        }

        public static DataTable MostrarDetalles(string textobuscar)
        {
            Dingresos Obj = new Dingresos();

            return Obj.MostrarDetalles(textobuscar);
        }
    }
}
