namespace carrito.Helpers
{
    public static class GeneradorPassword
    {
        const string chars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_=+";
        const int length = 12;

        public static string PasswordGenerator()
        {
            Random random = new Random();
           
            string password = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());

            return password;
        }

    }
}
