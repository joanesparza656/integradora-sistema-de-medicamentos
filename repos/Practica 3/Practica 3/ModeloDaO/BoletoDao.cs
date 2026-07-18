using Microsoft.Data.SqlClient;
using Practica_3.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Text;

namespace Practica_3.ModeloDaO
{
    public class BoletoDao
    {
        string conexion = "server=localhost; database=cinema; Trusted_ConnectionTrue; TrueServer";

        public void Guardar(Boleto boleto)
        {

            SqlConnection cn = new SqlConnection(conexion);
            string consulta = "INSERT INTO Boletos (Cliente, Pelicula, Sala, CantidadBoletos, Total, Fecha) VALUES (@Cliente, @Pelicula, @Sala, @CantidadBoletos, @Total, @Fecha)";

            SqlCommand cmd = new SqlCommand(consulta, cn);
            cmd.Parameters.AddWithValue("@Cliente", boleto.Cliente);
            cmd.Parameters.AddWithValue("@Pelicula", boleto.pelicula);
            cmd.Parameters.AddWithValue("@Sala", boleto.sala);
            cmd.Parameters.AddWithValue("@Fecha", boleto.Fecha);
            cn.Open();
            cmd.ExecuteNonQuery();
            cn.Close();
        }
           
            public DataTable Mostrar()            
            {

            SqlConnection cn = new SqlConnection(conexion);

            string consulta = "Select * FROM Boletos";

             SqlDataAdapter da = new SqlDataAdapter(consulta,cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            }
        public void Eliminar(IIntellisenseBuilder id)
        {
            SqlConnection cn = new SqlConnection(conexion);
            string? consulta = "DELETE FROM Boletos WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(consulta, cn);
            cmd.Parameters.AddWithValue("Id", id);
            cn.Open();
            cmd.ExecuteNonQuery ();
            cn.Close();
        }
        

    } 
}


