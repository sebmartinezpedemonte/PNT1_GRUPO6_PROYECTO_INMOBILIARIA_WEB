using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class PropVenta: Propiedad
    {
        public PropVenta(int idPropiedad, string descripcion, double precio, string srcImagen) : base(idPropiedad, descripcion, precio, srcImagen)
        {
        }

        override
        public void CalcularContrato()
        {

        }

    }
}
