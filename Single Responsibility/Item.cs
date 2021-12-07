namespace Single_Responsibility
{
    public class Item
    { // Propiedades 
        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

        //Constructor 
        public Item(Producto producto, int cantidad)
        {
            Producto = producto;
            Cantidad = cantidad;
        }

        // Metodo para calcular el subtotal de los productos
        public double Subtotal()
        {
            return Cantidad * Producto.Precio;
        }
    }
}

