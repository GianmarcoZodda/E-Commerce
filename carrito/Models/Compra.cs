namespace carrito.Models
{
    public class Compra
    {

        public int Id { get; set; }

        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }    

        public int IdCarrito { get; set; }
        public Carrito carrito { get; set; }

        public double Total { get; set; }

    }
}
