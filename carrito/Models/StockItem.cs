namespace carrito.Models
{
    public class StockItem
    {
        public int Id { get; set; }

        public int IdSucursal { get; set; }

        public Sucursal Sucursal { get; set; }

        public int IdProducto { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

    }
}
