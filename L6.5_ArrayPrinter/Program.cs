using System;

namespace L6._5_ArrayPrinter
{
    class ArrayPrinter
    {
        static void Main(string[] args)
        {
            //initialize variables
            string[] students = new string[]  { "Ben", "Mark" , "Sandy" ,
                                                "Heather" , "Steve" , 
                                                "Stu" , "Bill", "Sue" ,
                                                "Tom" , "Alfonzo" };            
            bool keepGoing = true;

            Console.WriteLine("This program gives a list of the  students " +
                                "in the class");            

            while (keepGoing)
            {
                if (GetInput() == "print")
                {
                    //get input, convert and display the results
                    for (int i = 0; i < students.Length; i++)
                        Console.WriteLine(students[i]);
                }

                //exit program               
                if (ExitProgram())
                {
                    Console.WriteLine("Goodbye!");
                    System.Threading.Thread.Sleep(1000);
                    break;
                }
            }
        }

        public static String GetInput()
        {
            string input = "";
            Console.WriteLine("Type \"print\" to list the students in class");
            input = Console.ReadLine();

            //check that there is actually some input
            if (input == "")
            {
                return GetInput();
            }
            else { return input; }
        }

        //exit the program when the user wants to
        public static Boolean ExitProgram()
        {
            Console.WriteLine("Do you want to continue? Enter Y or N.");
            var KP = Console.ReadKey(true);

            while (KP.Key != ConsoleKey.N && KP.Key != ConsoleKey.Y)
            {
                Console.WriteLine("Not a vaid answer. Do you want to " +
                    "continue? Enter Y or N.");
                KP = Console.ReadKey(true);
            }
            return KP.Key == ConsoleKey.N ? true : false;
        }
    }
}
