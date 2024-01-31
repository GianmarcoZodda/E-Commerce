using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.ViewModels
{
    public class EmpleadoCreateVM
    {

        public int Id { get; set; }

        [EmailAddress(ErrorMessage = ErrorMsgs.EmailInvalido)]
        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Display(Name = "Correo Electronico")]
        public string Email { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(1000000, 99999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int DNI { get; set; }

    }
}
