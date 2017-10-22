using System;
// Converting a number in Range (0,999) to an English word 
namespace NumberToWordConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number;
                number = int.Parse(Console.ReadLine());

                //Numbers from 0 to 19
                string[] onesDigit = { "zero", "one", "two", "three", "four", "five", "six ", "seven", "eight", "nine","ten",
                "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

                string[] tensDigit = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninty" };


                if (number >=0 && number <= 19)
                {
                    Console.WriteLine(onesDigit[number]);
                }
                else if (number >= 20 && number <=999)
                {
                    int a = number % 10; // Getting the Number at ones' Digit 
                    int b = (number / 10) % 10; //Getting the Number at tens' Digit 
                    int c = (number / 100) % 10; //Getting the Number at hundreds' Digit 

                    //Numbers from 20 to 99 
                    if (number < 100)
                    {
                        if (a == 0)
                        {
                            Console.WriteLine(tensDigit[b - 2]);
                        }
                        else
                        {
                            Console.WriteLine(tensDigit[b - 2] + "-" + onesDigit[a]);
                        }
                    }

                    //Numbers from 100 to 999
                    else
                    {

                        if (a == 0 && b == 0)
                            Console.WriteLine(onesDigit[c] + " hundred");
                        else if (a + 10 * b < 20)
                        {
                            Console.WriteLine(onesDigit[c] + " hundred and " + onesDigit[a + 10 * b]);
                        }
                        else
                        {
                            if (a != 0 && b != 0)
                            {
                                Console.WriteLine(onesDigit[c] + " hundred and " + tensDigit[b - 2] + "-" + onesDigit[a]);
                            }
                            else if (a == 0)
                            {
                                Console.WriteLine(onesDigit[c] + " hundred and " + tensDigit[b - 2]);
                            }
                            

                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a number between 0 and 999");
                }
            }
                Console.ReadLine();

           
        }

        


            

    }
}
