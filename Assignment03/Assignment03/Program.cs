using System;

namespace Assignment03
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Enter Number of students :");
            int number = Convert.ToInt32(Console.ReadLine());


            //Initializing 2 Arrays to store names and degrees of students 
            string[] names = new string[number];
            int[] degrees = new int [number];

            
            //Getting data from user 
            for ( int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter student {0} name " , i+1 );
                names[i] = Console.ReadLine();
                Console.WriteLine("Enter his/her degree :");
                degrees[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Choose an option from the following menu \n" +
                "========================== \n"
                + "[1] Search for a student degree \n" + 
                "[2] Get top student name and degree\n" +
                "[3] Change a student name");
            Console.WriteLine("Please enter your choice :");

            int choice = Convert.ToInt32(Console.ReadLine());
            if ( choice == 1 )
            {
                Console.WriteLine("Please enter student name :");
                string studentName = Console.ReadLine();
                int index = Student(names, studentName);
                Console.WriteLine("Student {0} score is : {1}" , studentName ,degrees[index]);

            }
            else if ( choice == 2)
            {
                int index = Top(degrees);
                Console.WriteLine("The Student name is : {0} and his/her score is {1}", names[index], degrees[index]);
            }
            else if ( choice == 3)
            {
                Console.WriteLine("Type the name of student to be changed (old name ) :");
                string oldName = Console.ReadLine();
                Console.WriteLine("Enter New Name :");
                string newName = Console.ReadLine();

                int index = Student(names, oldName);
                names.SetValue(newName, index);
                Console.WriteLine("Name successfully changed from {0} to {1}.",oldName,newName);
                

            }
            else
            {
                Console.WriteLine("Please enter a valid choice !");
            }

            Console.ReadLine();
        }

        //method to Search for a student degree [ index ]
        static int Student(string[] n , string name)
        {
            int studentIndex = Array.IndexOf(n, name);
            return studentIndex;
        }

        //method to  Get top student [ Index ]
        static int Top(int[] d )
        {
            int topDeg = d[0];
            int topIndex = 0;
            for ( int i = 1; i < d.Length; i ++)
            {
                if(d[i] > topDeg)
                {
                    topDeg = d[i];
                    topIndex = i;
                }
            }

            return topIndex;

        }

        
    }
}
