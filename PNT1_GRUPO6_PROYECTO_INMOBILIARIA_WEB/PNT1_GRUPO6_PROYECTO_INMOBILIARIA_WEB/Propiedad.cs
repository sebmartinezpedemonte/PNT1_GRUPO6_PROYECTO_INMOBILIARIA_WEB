using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    abstract class Propiedad
    {
        

        private int IdPropiedad { get; set; }
        private string Descripcion { get; set; }

        private double Precio { get; set; }

        private string SrcImagen { get; set; }

        protected Propiedad(int idPropiedad, string descripcion, double precio, string srcImagen)
        {
            IdPropiedad = idPropiedad;
            Descripcion = descripcion;
            Precio = precio;
            SrcImagen = srcImagen;
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

        abstract public void CalcularContrato();

    }
}
