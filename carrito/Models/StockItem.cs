using System.ComponentModel.DataAnnotations.Schema;

namespace carrito.Models
{
    public class StockItem
    {
        public int Id { get; set; }

        public int SucursalId { get; set; }

        public Sucursal Sucursal { get; set; }

        [ForeignKey("Producto")]
        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

        public int Cantidad { get; set; }

    }
}
