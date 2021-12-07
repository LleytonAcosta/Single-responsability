using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;
namespace Single_Responsibility
{

    public class Factura
    {
        // Propuedades 
        public int Cedula { get; set; }

        public DateTime Fecha { get; set; }

        public List<Item> Items { get; set; }

        public string Nombre  { get; set; }

        public string Apellido { get; set; }
        
        // Constructor 

        public Factura(int cedula, string nombre, string apellido)
        {
            Nombre = nombre;
            Cedula= cedula;
            Apellido = apellido ;
            Fecha = DateTime.Today;
            Items = new List<Item>();
        }

        // Calculo del total de los productos
        public double Total()
        {
            double total = 0;
            foreach(var item in Items)
            {
                total += item.Cantidad* item.Producto.Precio;
            }
            return total;
        }


    }  
}
