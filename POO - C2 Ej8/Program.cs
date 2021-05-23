using System;

namespace POO___C2_Ej8
{
    class Password
    {
        internal static string password;
        internal static int longitud;

        public Password()
        {
            password = "";
            longitud = 8;
        }

        public Password(int nlongitud)
        {
            longitud = nlongitud;

            var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            var stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            password = new string(stringChars);


        }

        static void Main(string[] args)
        {
            Password mipassword = new Password(8);

            System.Console.WriteLine(password);

        }
    }
}
