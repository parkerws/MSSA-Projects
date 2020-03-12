using System;
using System.Collections.Generic;
using System.Security;
using System.Text;
using System.Security.Cryptography;
using static System.String;

namespace Hashing_Authentication
{
    class Password
    {
        public static string SHA256HashGenerator(string password)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(password));

                StringBuilder buildHash = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    buildHash.Append(hashBytes[i].ToString("x2"));
                }

                return buildHash.ToString();
            }
        }

        public static string PasswordMasker()
        {
            StringBuilder passMaker = new StringBuilder();
            ConsoleKeyInfo input;
            do
            {
                string display = "";
                input = Console.ReadKey(true);

                if ((int) input.Key >= 33 && (int) input.Key <= 125)
                {
                    passMaker.Append(input.KeyChar);
                    Console.Write("*");

                }
                else if (input.Key == ConsoleKey.Backspace)
                {
                    if (!IsNullOrWhiteSpace(passMaker.ToString()))
                    {
                        passMaker.Remove(passMaker.Length - 1, 1);
                        Console.Write("\b \b");
                    }
                }
                Console.Write(display);
            } while (input.Key != ConsoleKey.Enter);

            return passMaker.ToString();
        }
    }
}
