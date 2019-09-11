using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapaNegocio
{
   public  class NClientes
    {
        public static string Insertar(string nombre,string apellidos,string sexo,DateTime fecha_nacimiento, string tipo_documento,string num_documento,string direccion,string telefono,string email)
        {
            DClientes Obj = new DClientes();

            Obj.Nombre = nombre;
            Obj.Apelidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Tipo_documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;

            return Obj.Insertar(Obj);
        }

        public static string Editar(int idcliente,string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string tipo_documento, string num_documento, string direccion, string telefono, string email)
          
        {
            DClientes Obj = new DClientes();

            Obj.Idcliente = idcliente;
            Obj.Nombre = nombre;
            Obj.Apelidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Tipo_documento = tipo_documento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
                       
            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idcliente)
        {
            DClientes Obj = new DClientes();

            Obj.Idcliente = idcliente;

            return Obj.Eliminar(Obj);
        }

        public static DataTable Mostrar()
        {
            return new DClientes().Mostrar();
        }

        public static DataTable BuscarClientes_Apellido(string textobuscar)
        {
            DClientes Obj = new DClientes();

            Obj.TextoBuscar = textobuscar;
            return Obj.BuscarClientes_Apellido(Obj);
        }

        public static DataTable Buscarcliente_num_documento(string textobuscar)
        {
            DClientes Obj = new DClientes();

            Obj.TextoBuscar = textobuscar;
            return Obj.Buscarcliente_num_documento(Obj);
        }

    }
}
