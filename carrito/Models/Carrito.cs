namespace carrito.Models
{
    public class Carrito
    {
        public int Id { get; set; }
        public bool Activo { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }

        public List<CarritoItem> CarritoItems { get; set; }

        public int IdCompra { get; set; }

        public Compra Compra { get; set; }

        public double Subtotal { get; set; }

    }
}
