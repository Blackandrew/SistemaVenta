using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class Conexion
    {
        //configuar app.config para genera el instlador
        //CLICK derecho sobre el archivo principal propiedades  y configurar publicar y aplicaciones
        //configuracion en red
        //tener instalado el net framewor el cual tiene,report viwer y sqlserver managerstudio
       // public static string Cn = "Data Source=(local);Initial Catalog=dbventas;Integrated Security=True"; //cadena de conexion
        //referencia a la cadena de conexion sin afectar la clase

        //"Data Source = IPPUBLICA:1433; Initial Catalog = TUBD; User ID = USUARIO;  Password = CONTRASEÑA"
        public static string Cn =Properties.Settings.Default.cn ;
    }
}
