using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.Models
{
    public class Persona
    {
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = ErrorMsgs.StrMinMax)]
        [Display(Name = "Usuario")]
        public string UserName { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 8, ErrorMessage = ErrorMsgs.StrMinMax)]
        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Password { get; set; }

        [EmailAddress(ErrorMessage = ErrorMsgs.EmailInvalido)]
        [Required(ErrorMessage = ErrorMsgs.Required)]
        public string Email { get; set; }

        [Display(Name = "Fecha de Alta")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0: dd/MM/yy}")]
        public DateTime FechaAlta { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(1000000, 99999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int DNI { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Range(100000000, 99999999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int Telefono { get; set;}

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(100, MinimumLength = 5, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Direccion { get; set; }
    }
}
