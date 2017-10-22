using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueOfBit
{
    class Program
    {
        static void Main(string[] args)
        {
            int number , p;
            string binary;

            Console.WriteLine("Enter a number :");
            number = int.Parse(Console.ReadLine());

            binary = Convert.ToString(number, 2);
            Console.WriteLine("The Number in Binary :\n" + binary );

            Console.WriteLine("Enter a specific Position P :");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine("The value of Bit at Position  " + p + " is:\n" + binary[p - 1]);
            Console.ReadLine();
        }
    }
}
