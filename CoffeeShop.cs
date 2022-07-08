namespace Learning
{
    public class CoffeeShop
    {
        public void BuyCoffee()
        {
            Console.WriteLine("Hello, here is the menu");
            Console.WriteLine(@"1. Capuccino - $5
2. Arabica - $2.25
3. Decaf - $3
4. Black Coffee - $2.50
5. Latte - $4.20");
            double TotalCoffee = 0;

            Start:
            Console.WriteLine("Please make your coffee selection: ");
            string CustomerChoice = Console.ReadLine().ToUpper();

            switch (CustomerChoice)
            {
                case "CAPUCCINO":
                    TotalCoffee += 5;
                    break;
                case "ARABICA":
                    TotalCoffee += 2.25;
                    break;
                case "DECAF":
                    TotalCoffee += 3;
                    break;
                case "BLACK COFFEE":
                    TotalCoffee += 2.50;
                    break;
                case "LATTE":
                    TotalCoffee += 4.20;
                    break;
                default:
                    Console.WriteLine("Invalid selection!!! Please make a selection from the menu");
                    goto Start;
            }
            
            Decide:
            Console.WriteLine("Do you want to buy another coffee? Yes or No: ");
            var CustomerResponse = Console.ReadLine().ToUpper();

            switch (CustomerResponse)
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine($"So far, your bill is {TotalCoffee}.\nPlease make a vaid slection (Yes or No) to continue");
                    goto Decide;      
            }

            Console.WriteLine("Thank you for shopping with us, here is your coffee");
            Console.WriteLine($"Your bill amount is ${TotalCoffee}");
        }
    }
}