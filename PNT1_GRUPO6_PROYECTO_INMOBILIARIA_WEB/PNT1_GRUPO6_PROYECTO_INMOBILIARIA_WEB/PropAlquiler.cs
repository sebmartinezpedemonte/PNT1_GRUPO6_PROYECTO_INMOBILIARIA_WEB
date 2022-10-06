using System;
using System.Collections.Generic;
using System.Text;

namespace PNT1_GRUPO6_PROYECTO_INMOBILIARIA_WEB
{
    class PropAlquiler : Propiedad
    {
        private int CantMeses { get; set; }

        public PropAlquiler(int idPropiedad, string descripcion, double precio, string srcImagen, Tipo tipo, int cantMeses) : base(idPropiedad, descripcion, precio, srcImagen, tipo)
        {
            CantMeses = cantMeses;
        }

        


        public override void CalcularContrato()
        {
            throw new NotImplementedException();
        }
    }
}
