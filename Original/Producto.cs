using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class Producto
    { // Propiedades de los productos

        public string Descripcion { get; set; }

        public Double Precio { get; set; }

        // Metodo constructor 
        public Producto(string descripcion, double precio)
        {
            Descripcion = descripcion;
            Precio = precio;
        }
    }
}
