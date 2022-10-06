using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class PropAlquiler : Propiedad
    {
        private int CantMeses { get; set; }

        public PropAlquiler(int idPropiedad, string descripcion, double precio, string srcImagen) : base(idPropiedad, descripcion, precio, srcImagen)
        {
        }

        



        public override void CalcularContrato()
        {
            throw new NotImplementedException();
        }
    }
}
