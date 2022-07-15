using System;
using Device;

namespace Learning
{
    public class Program : I1, I2
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
            //Family Adewale = new Family();
            //Adewale.AssetValue();
            // Console.WriteLine(Adewale.GetDaugther());

            // Family Opeola = new Family();
            // Opeola = new ExtdFamily("Tosin", "Tofunmi", "Bukunmi", "Dorcas");
            // Opeola.AssetValue();

            //4. Convert strings ti integer
            // DataTypeConversions();

            //5 Print even numbers in an array
            //EvenNumbers();

            //6. A coffe shop bill printer
            //CoffeeShop coffeeShop = new CoffeeShop();
            //coffeeShop.BuyCoffee();

            //PrintEvenNumbers();

            // int i = 0;

            // simpleMethod(ref i);

            // Console.WriteLine(i);   

            // int Total = 0;
            // int Product = 0;
            // Calculate(20, 30, out Total, out Product);    

            // Console.WriteLine($"The sum is {Total} and the product is {Product}");

            // int[] Numbers = new int[3];

            // Numbers[0] = 101;
            // Numbers[1] = 102;
            // Numbers[2] = 103;

            // ParamsMethod(Numbers);
            // BaseClass B = new DerivedClass();
            // B.Print();

            // Customer Raphael = new Customer();
            // Raphael.Id = 1;
            // Raphael.Name = "Raphael";
            // Raphael.PrintDetails();

            // Program P = new Program();
            // P.InterfaceMethod();
            // ((I2)P).InterfaceMethod();

            AB ab = new AB();
            ab.PrintA();
            ab.PrintB();

        }

        // implementing interface1
        public void InterfaceMethod()
        {
            Console.WriteLine("This is interface 1");
        }

        void I2.InterfaceMethod()
        {
            Console.WriteLine("This is interface 2");
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

            // for (int i = 0; i < 10; i++)
            // {
            //     if (i % 2 == 0)
            //     {
            //         evennumbers[i] = i;
            //         Console.WriteLine(i);
            //     }
            // }

            foreach (int j in evennumbers)
            {
                Console.WriteLine(j);
            }
        }

        static void PrintEvenNumbers()
        {
            Console.WriteLine("Please enter your target: ");
            int userTarget = Convert.ToInt32(Console.ReadLine());
            int Start = 0;

            while (Start < userTarget)
            {
                Console.WriteLine(Start);
                Start += 2;
            }
        }

        static void simpleMethod(ref int j)
        {
            j = 101;
        }

        static void Calculate(int FN, int SN, out int Sum, out int Product)
        {
            Sum = FN + SN;
            Product = FN * SN;
        }

        static void ParamsMethod(params int[] Numbers)
        {
            Console.WriteLine($"There are {Numbers.Length} elements in the Numbers array");

            foreach (int i in Numbers)
            {
                Console.WriteLine(i);
            }
        }
    }
}