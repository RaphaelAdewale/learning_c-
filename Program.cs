using System;

namespace Learning
{
    public class Program
    {
        public static void Main()
        {
            //0. Basic Methods
            //0a.SayHi("Raphael", 24);
            // SayHi("Esther", 21);
            // SayHi("Sylvester", 18);

            //0b. ar();

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

            Family Adewale = new Family("Olusanya", "flora", "esther", "jeremiah");
            //Adewale.AssetValue();
            Console.WriteLine(Adewale.GetDaugther());

        }

        // Introduce yourself
        static void SayHi(string name, int age)
        {
            Console.WriteLine("Hello " + name + ", your are " + age + " years old");
        }

        //writing a 2d array
        static void ar()
        {
            string[,] Family = {
                {"Victor", "Flora"},
                {"Jeremiah", "Raphael"},
                {"Esther", "Sylvester"},
                {"Timilehin", "Daniel"},
            };

            Console.WriteLine(Family[3,0]);
        }
    }
}