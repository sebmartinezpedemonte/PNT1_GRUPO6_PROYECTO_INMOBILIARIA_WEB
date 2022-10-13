using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    abstract class Propiedad
    {
        
        public int IdPropiedad { get; set; }
        public string Descripcion { get; set; }

        public double Precio { get; set; }

        public string SrcImagen { get; set; }

        public Tipo Tipo { get; set; }

        protected Propiedad(int idPropiedad, string descripcion, double precio, string srcImagen, Tipo tipo)
        {
            IdPropiedad = idPropiedad;
            Descripcion = descripcion;
            Precio = precio;
            SrcImagen = srcImagen;
            Tipo = tipo;
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
