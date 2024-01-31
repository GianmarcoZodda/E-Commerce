using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.ViewModels
{
    public class ClienteEditVM
    {

        public int Id { get; set; }

        [Range(100000000, 99999999999, ErrorMessage = ErrorMsgs.MaxMin)]
        public int Telefono { get; set; }
        
        [StringLength(100, MinimumLength = 5, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Direccion { get; set; }

    }
}
