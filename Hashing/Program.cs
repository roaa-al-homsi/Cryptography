using System;
using System.Security.Cryptography;
using System.Text;

namespace Hashing
{
    internal class Program
    {
        public static string ComputeHash(string input)
        {
            //SHA is security hash algorithm.
            //Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                //compute the hash value from the UTF-8 encoded input string.
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

                //Convert the byte array to lowercase hexadecimal string.
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
        static void Main(string[] args)
        {

            string name = "Roaa Homsi";
            string hashData = ComputeHash(name);
            Console.WriteLine($" Before hashing:{name}");
            Console.WriteLine($"After hashing:{hashData}");
            Console.ReadKey();
        }
    }
}
