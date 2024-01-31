using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.ViewModels
{
    public class EmpleadoEditVM
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = ErrorMsgs.StrMinMax)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(100000000, 99999999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int Telefono { get; set; } = 100000001;

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Direccion { get; set; }

    }
}
