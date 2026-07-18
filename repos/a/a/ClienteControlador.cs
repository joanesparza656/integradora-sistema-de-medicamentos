using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;

    public class ClienteControlador
    {
        public List<Cliente> ListarClientes()
        {
            List<Cliente> lista = new List<Cliente>();
            SqlConnection con = Conexion.ObtenerConexion();

            try
            {
                con.Open();
                string query = "SELECT Id, Nombre, Telefono FROM Clientes";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Cliente c = new Cliente
                    {
                        Id = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Telefono = reader.GetString(2)
                    };
                    lista.Add(c);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al listar clientes: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

            return lista;
        }
    }

}
