using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.Models
{
    public class Categoria
    {

        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 2, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(100, MinimumLength = 10, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Descripcion {  get; set; }

        public List<Producto> Productos { get; set;}
    }
}
