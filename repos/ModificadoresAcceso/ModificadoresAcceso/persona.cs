using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcceso
{
    public class Persona
    {

        private string nombre;
        private string apeliido;

        public Persona(string pNombre, string pApeliido)
        {
                nombre = pNombre;
            apeliido = pApeliido;

        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;

            }
            

        }
           public string Apellido
           {
            get
            {
                return apeliido;
            }
            set
            {
                apeliido = value;
            }

           }


    }
}
