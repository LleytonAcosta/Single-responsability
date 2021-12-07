using System;
using System.Collections.Generic;
using System.Text;
//using System.Threading.Tasks;
namespace Single_Responsibility
{

    public class Factura
    { 
        // Propiedades 
        public int Cedula { get; set; }

        public DateTime Fecha { get; set; }

        public List<Item> Items { get; set; }

        // Se simplifica los datos del cliente es decir el nombre y apellido
        public Cliente Cliente { get; set; }

        // Constructor ya no se necesita un nombre y apellido si no que ahora ya se tiene la responsabilidad de conocer los datos del cliente
        public Factura(int cedula, Cliente cliente)
        {
            Cedula = cedula;
            Cliente = cliente;
            Items = new List<Item>();
            Fecha = DateTime.Today;
        }

        //  Pedirle a cada item su subtotal

        public double Total()
        {
            double total = 0;
            foreach(var item in Items)
            {
                total += item.Subtotal();
            }
            return total;
        }


    }  
}
