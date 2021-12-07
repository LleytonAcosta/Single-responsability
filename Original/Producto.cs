using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class Producto
    {
        public string Descripcion { get; set; }

        public Double Precio { get; set; }

        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
