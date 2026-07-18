using System;

namespace ProyectoLogin
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public Cliente() { }

        public Cliente(int id, string nombre, string direccion, string telefono, string email)
        {
            Id = id;
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
            Email = email;
        }

        public override string ToString()
        {
            return $"{Nombre} ({Email})";
        }
    }
}