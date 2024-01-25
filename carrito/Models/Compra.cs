namespace carrito.Models
{
    public class Compra
    {

        public int Id { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }    

        public double Total { get; set; }

        public int CarritoId { get; set; }

        public Carrito Carrito { get; set; }

    }
}
