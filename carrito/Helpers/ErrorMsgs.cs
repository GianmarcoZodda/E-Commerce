using System.Runtime.ConstrainedExecution;

namespace carrito.Helpers
{
    public class ErrorMsgs
    {
        public const string Required = "el campo {0} es requerido";
        public const string StrMinMax = "Debe estar comprendido entre {2} y {1}";
        public const string EmailInvalido = "El {0} es invalido";
        public const string MaxMin = "El valor debe ser menor que {2} y mayor que {1}";
    }
}
