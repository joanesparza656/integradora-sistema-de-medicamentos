using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_3.Modelo
{
    public class Boleto
    {
        public int Id { get; set; }
        public string? Cliente { get; set; }
        public string? pelicula { get; set; }
        public int? sala { get; set; }
        public int? cantidadBoletos { get; set; }
        public decimal? Total { get; set; }
        public DateTime? Fecha { get; set; }



    }
}
