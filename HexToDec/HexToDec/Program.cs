using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToDec
{
    class Program
    {
        static void Main(string[] args)
        {
            string hex;
            Console.WriteLine("Enter a Hexa Number : ");
            hex = Console.ReadLine();

            int dec = Convert.ToInt32(hex, 16);
            Console.WriteLine("The number in decimal =  " + dec);

            Console.ReadKey();

        }
    }
}
