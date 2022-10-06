using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class Usuario
    {

        private int IdUsuario { get; set; };
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Email { get; set; }
        private string Contrasena { get; set; }

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
