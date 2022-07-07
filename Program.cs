using System;

namespace Learning
{
    public class Program
    {
        public static void Main()
        {
            //0. Basic Methods
            //SayHi("Raphael", 24);
            // SayHi("Esther", 21);
            // SayHi("Sylvester", 18);

            //0b. twodAr();

            // 1. initializing the Identity class
            //Identity identity = new Identity();

            // 1a. ask for details
            //identity.input_persona();
            // 1b. print out details
            //identity.write_persona();

            // 2. initializing the calculator
            //Calculator calculator = new Calculator();

            // 2a. add numbers
            //calculator.addition();

            // 2b. calculator using four operations (+, -, /, *)
            //calculator.FourOperations();

            // 3. All my projects in the first learning phase
            // projects are referenced in the project.cs file
            //Projects projects = new Projects();

            // 3a. A madlibs game
            //projects.MadLibs();

            // 3b. printing the maximum of three numbers
            //var num = projects.GetMax(21, 24, 18);
            //Console.WriteLine(num + " is the maximum number");

            // 3c. A guessing game
            //projects.GuessingGame();

            //3d. An exponent function
            // works for only positive numbers
            //Console.WriteLine(projects.Exponent(5,20));

            //Family Adewale = new Family("Victor", "flora", "esther", "jeremiah");
            //Adewale.AssetValue();
            // Console.WriteLine(Adewale.GetDaugther());

            //4. Convert strings ti integer
            // DataTypeConversions();

            //5 Print even numbers in an array
            //EvenNumbers();

            //6. A coffe shop bill printer
            CoffeeShop coffeeShop = new CoffeeShop();
            coffeeShop.BuyCoffee();
        }

        // Introduce yourself
        static void SayHi(string name, int age)
        {
            Console.WriteLine($"Hello {name}, your are {age} years old");
            Console.WriteLine(@"The directory of this file is C:\Documents\C#_Practice");
            //using tenary operator
            bool IsName = name == "Raphael" ? true : false;
            Console.WriteLine(IsName);
        }

        //writing a 2d array
        static void twodAr()
        {
            string[,] Family = {
                {"Victor", "Flora"},
                {"Jeremiah", "Raphael"},
                {"Esther", "Sylvester"},
                {"Timilehin", "Daniel"},
            };

            Console.WriteLine(Family[3,0]);
        }

        static void SimpleConcepts()
        {
            int? TicketSales = null;
            int AvailableTickets = TicketSales ?? 0;
        }

        static void DataTypeConversions()
        {
            string i = "1002324";
            int result = 0;
            
            bool isConversionSuccessful = int.TryParse(i, out result);
            if (isConversionSuccessful)
            {
                Console.WriteLine(i);
            }
            else
            {
                Console.WriteLine("Please input a valid number");
            }
        }

        /// <summary>
        ///  This is a simple class that prints even numbers between 1 and 10
        /// <summary>
        static void EvenNumbers()
        {
            int[] evennumbers = new int[10];

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    evennumbers[i] = i;
                    Console.WriteLine(i);
                }
            }
        }

    }
}