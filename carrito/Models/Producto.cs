using carrito.Helpers;
using System.ComponentModel.DataAnnotations;

namespace carrito.Models
{
    public class Producto
    {
      
        public int Id { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(50, MinimumLength = 4, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [StringLength(100, MinimumLength = 4, ErrorMessage = ErrorMsgs.StrMinMax)]
        public string Descripcion { get; set; }

        [Required(ErrorMessage = ErrorMsgs.Required)]
        [Display(Name = "Precio")]
        public double PrecioVigente { get; set; }
        public bool Activo { get; set; } = true;
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public string Imagen { get; set; }

        public int StockItemId { get; set; }

        public StockItem StockItem { get; set; }    

        public List<CarritoItem> CarritoItems { get; set; }


    }
}
