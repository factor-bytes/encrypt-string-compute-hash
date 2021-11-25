using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Compute Hash - Press 1");
            Console.ReadLine();
            Console.Write("Confirm Hash - Press 2");
            Console.ReadLine();
            var opt = Console.ReadLine();
            switch (opt)
            {
                case "1":
                    computeHash();
                    break;

                case "2":
                    confirmHash();
                    break;

                default:
                    break;

            }
        }

        private static void computeHash()
        {
            do
            {
                Console.WriteLine("Enter String");
                var str = "";
                str = Console.ReadLine();
                Console.Write("You entered --- " + str);
                Console.ReadLine();
                var hash = Cryptography.ComputeHash(str, Cryptography.Supported_HA.SHA512, null);
                Console.WriteLine(hash.ToString());
                Console.ReadLine();
                Console.WriteLine("Press Escape to exit");
            }
            while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

        private static void confirmHash()
        {
                Console.WriteLine("Enter String");
                var str = "";
                str = Console.ReadLine();
                Console.WriteLine("Enter Hash");
                var hash = "";
                hash = Console.ReadLine();
                Console.ReadLine();
                var result = Cryptography.Confirm(str,hash, Cryptography.Supported_HA.SHA512);
                if (result)
                    Console.WriteLine("Hash Confirmed");
                else
                    Console.WriteLine("Hash not Confirmed");

                Console.ReadLine();
        }
    }
}
