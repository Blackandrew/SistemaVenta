using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class NProveedor
    {
        public static string Insertar(string razon_social, string sector_comercial,string tipo_documento,string num_documento,string direccion,string telefono,string email,string url)
        {
            DProveedor Obj = new DProveedor();

            Obj.RazonSocial = razon_social;
            Obj.SectorComercial = sector_comercial;
            Obj.TipoDocumento = tipo_documento;
            Obj.NumDocumento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idproveedor, string razon_social, string sector_comercial, string tipo_documento, string num_documento, string direccion, string telefono, string email, string url)
        {
            DProveedor Obj = new DProveedor();

            Obj.Idproveedor = idproveedor;
            Obj.RazonSocial = razon_social;
            Obj.SectorComercial = sector_comercial;
            Obj.TipoDocumento = tipo_documento;
            Obj.NumDocumento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Url = url;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idproveedor)
        {
            DProveedor Obj = new DProveedor();

            Obj.Idproveedor = idproveedor;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DProveedor().Mostrar();
        }


        public static DataTable BuscarNum_Documento(string textobuscar)
        {
            DProveedor Obj = new DProveedor();

            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarNum_Documento(Obj);
        }
        public static DataTable BuscarRazon_Social(string textobuscar)
        {
            DProveedor Obj = new DProveedor();

            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarRazon_Social(Obj);
        }
    }
}
