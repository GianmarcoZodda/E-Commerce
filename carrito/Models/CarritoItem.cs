using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.Models
{
    public class CarritoItem
    {
        public int Id { get; set; }

        public int CarritoId { get; set; }

        public Carrito Carrito { get; set; }

        public int ProductoId { get; set; }

        public Producto Producto { get; set; }

        [Display(Name = "Valor Unitario")]
        public double ValorUnitario { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        public int Cantidad { get; set; }

        public double Subtotal { get; set; }

    }
}
