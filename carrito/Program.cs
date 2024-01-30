namespace carrito
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);



            var app = Startup.InicializarApp(args);

           
            app.Run();
        }
    }
}