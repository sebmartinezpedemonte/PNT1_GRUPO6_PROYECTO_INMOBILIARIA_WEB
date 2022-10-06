using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class PropVenta: Propiedad
    {
        public PropVenta(int idPropiedad, string descripcion, double precio, string srcImagen, Tipo tipo) : base(idPropiedad, descripcion, precio, srcImagen, tipo)
        {
        }

        override
        public void CalcularContrato()
        {

        }

    }
}
