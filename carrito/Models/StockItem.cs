using carrito.Helpers;
using System.ComponentModel.DataAnnotations;
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

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(0, int.MaxValue, ErrorMessage = ErrorMsgs.MinVal)]
        public int Cantidad { get; set; }

    }
}
