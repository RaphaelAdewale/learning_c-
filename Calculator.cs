public class Calculator
{
    public void addition()
    {
        try
        {
            //input first number
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            //input second number
            Console.Write("Enter another number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // calculate
            Console.WriteLine(num1 + num2);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error!!! Please try again.");
            Console.WriteLine(e.Message);
        }
        

    }

    //calculator using addition, subtraction
    //multiplication and division
    public void FourOperations()
    {
        //input first number
        Console.Write("Enter a number: ");
        double numeral1 = Convert.ToInt32(Console.ReadLine());

        //choose an operation
        Console.Write("Choose your preferred operation(+, -, /, or *): ");
        string? op = Console.ReadLine();

        //input second number
        Console.Write("Enter another number: ");
        double numeral2 = Convert.ToInt32(Console.ReadLine());

        /*if (op == "+")
        {
            Console.WriteLine(numeral1 + numeral2);
        } 
        else if (op == "-")
        {
            Console.WriteLine(numeral1 - numeral2);
        }
        else if (op == "/")
        {
            Console.WriteLine(numeral1 / numeral2);
        }
        else if (op == "*")
        {
            Console.WriteLine(numeral1 * numeral2);
        }
        else
        {
            Console.WriteLine("This is an invalid operation. Try again");
        }*/
        switch (op)
        {
            case "+":
                Console.WriteLine(numeral1 + numeral2);
                break;
            case "-":
                Console.WriteLine(numeral1 - numeral2);
                break;
            case "/":
                Console.WriteLine(numeral1 / numeral2);
                break;
            case "*":
                Console.WriteLine(numeral1 * numeral2);
                break;
            default:
                Console.WriteLine("This is an invalid operation. Try again");
                break;
        }
    }
}