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
   public  class NTrabajador
    {
      
        public static string Insertar(string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
        {
            DTrabajador Obj = new DTrabajador();

            Obj.Nombre = nombre;
            Obj.Apelidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Insertar(Obj);
        }

        public static string Editar( int idtrabajador , string nombre, string apellidos, string sexo, DateTime fecha_nacimiento, string num_documento, string direccion, string telefono, string email, string acceso, string usuario, string password)
         

        {

            DTrabajador Obj = new DTrabajador();

            Obj.Idtrabajador = idtrabajador;
            Obj.Nombre = nombre;
            Obj.Apelidos = apellidos;
            Obj.Sexo = sexo;
            Obj.Fecha_nacimiento = fecha_nacimiento;
            Obj.Num_Documento = num_documento;
            Obj.Direccion = direccion;
            Obj.Telefono = telefono;
            Obj.Email = email;
            Obj.Acceso = acceso;
            Obj.Usuario = usuario;
            Obj.Password = password;

            return Obj.Editar(Obj);
        }

        public static string Eliminar(int idtrabajador)
        {
            DTrabajador Obj = new DTrabajador();

            Obj.Idtrabajador = idtrabajador;

            return Obj.Eliminar(Obj);
        }


        public static DataTable Mostrar()
        {
            return new DTrabajador().Mostrar();
        }

        public static DataTable Buscarapellido_trabajador(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();

            Obj.TextoBuscar = textobuscar;
            return Obj.Buscarapellido_trabajador(Obj);
        }

        public static DataTable Buscarnum_docu_trabajador(string textobuscar)
        {
            DTrabajador Obj = new DTrabajador();

            Obj.TextoBuscar = textobuscar;
            return Obj.Buscarnum_docu_trabajador(Obj);
        }

        public static DataTable Login(string usuario,string pass)
        {
            DTrabajador Obj = new DTrabajador();
            Obj.Usuario = usuario;
            Obj.Password = pass;
            return Obj.Login(Obj);
        }
    }
}
