using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaMedicamentos
{
    public class Medicamento
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public int Cantidad { get; set; }
        public string Prioridad { get; set; }
        public string Area { get; set; } = string.Empty;
    }
}
