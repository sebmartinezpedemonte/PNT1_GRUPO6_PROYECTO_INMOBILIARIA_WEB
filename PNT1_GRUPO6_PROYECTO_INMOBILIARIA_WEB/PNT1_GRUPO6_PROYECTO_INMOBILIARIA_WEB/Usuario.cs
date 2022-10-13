using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class Usuario
    {

        public int IdUsuario { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasena { get; set; }

        public Usuario(int idUsuario, string nombre, string apellido, string email, string contrasena)
        {
            IdUsuario = idUsuario;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasena = contrasena;
        }



        public void Elimininar()
        {

        }

        public void Modificar()
        {

        }

        public void Agregar()
        {

        }
    }
}
