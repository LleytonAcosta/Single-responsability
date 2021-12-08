using System;
using System.Collections.Generic;
using System.Text;

namespace Single_Responsibility
{
    public class Item
    {
        //Propiedades 

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }
        
        //Metodo Item 
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;

        }
       
    }
}

