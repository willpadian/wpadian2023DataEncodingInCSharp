using System;

namespace wpadian2023DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}.");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            Console.WriteLine($"The encrypted message is: {message}");



            // Cipher cipher;
            // cipher = new Cipher(5);

            // string encrypted;
            // encrypted = cipher.Encrypt("rosebud");
            // Console.WriteLine($"The encrypted message is: '{encrypted}'");

            // string decrypted;
            // decrypted = cipher.Decrypt(encrypted);
            // Console.WriteLine($"The decrypted message is {decrypted}");

            int shift = 0;
            while (shift <= 10)
            {
                Cipher cipher;
                cipher = new Cipher(shift);
                string decrypted;
                decrypted = cipher.Decrypt(message);
                Console.WriteLine($"The decrypted message with shift {shift} is: '{decrypted}'");
                shift = shift + 1;


            }
        }
    }
}
