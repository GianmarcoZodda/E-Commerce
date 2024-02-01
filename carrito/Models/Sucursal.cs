using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.Models
{
    public class Sucursal
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(80, MinimumLength = 4, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(100000000, 99999999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int Telefono { get; set; }

        [EmailAddress(ErrorMessage = ErrorMsgs.EmailInvalido)]
        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        public List<StockItem> StockItems { get; set; }

    }
}
