using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    using System.Data.SqlClient;

    public class Conexion
    {
        private static string cadena = "Server=TU_SERVIDOR;Database=TuBaseDeDatos;Trusted_Connection=True;";
        private static SqlConnection conexion = null;

        public static SqlConnection ObtenerConexion()
        {
            if (conexion == null)
            {
                conexion = new SqlConnection(cadena);
            }
            return conexion;
        }
    }

}
