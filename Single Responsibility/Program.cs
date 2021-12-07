using System;

namespace Single_Responsibility
{
    class Program
    {

     
        static void Main(string[] args)
        {
            // Datos del cliente
            Cliente cliente = new Cliente();
            cliente.Apellido = " Acosta";
            cliente.Nombre = "Lleyton";

            // Datos que se implementa a la factura con un producto con precio y una cantidad
            Factura factura = new Factura(1314978, cliente);

            Item item_1 = new Item(new Producto("Pan",5), 5);

            Item item_3 = new Item(new Producto("Aceite",100), 2);

            Item item_2 = new Item(new Producto("Jugo", 50), 3);

            // Items o productos 
            factura.Items.Add(item_1);
            factura.Items.Add(item_2);
            factura.Items.Add(item_3);

            // Se muestra la factura
            Console.WriteLine("Fecha:" + factura.Fecha);
            Console.WriteLine("Cedula:" + factura.Cedula);
            Console.WriteLine("Cliente:" + cliente.Nombre + cliente.Apellido);
            Console.WriteLine("Toltal de la comra: $"+factura.Total());
        }  
       
    }
}
