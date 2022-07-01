namespace Learning
{
    public class Family
    {
        private string? father;
        public string mother;
        public string son;
        public static string? daugther;

        public string? Father
        {
            get {return father;}
            set 
            {
                if(value == "Victor")
                {
                    father = value;
                }
                else
                {
                    father = "Not Victor";
                }
            }
        }

        // creating this method because the daughter atrribute is static
        public string? GetDaugther()
        {
            return daugther;
        }

        public Family(string king, string queen, string princess, string prince)
        {
            Father = king;
            mother = queen;
            daugther = princess;
            son = prince;
        }

        public void AssetValue()
        {
            double cash;
            double land;
            double business;
            double stock;
            double value;

            try
            {
                Console.Write("How much money does your family have in the bank? ");
                cash = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the value of the real estate your family has? ");
                land = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the shareholder equity of your family business? ");
                business = Convert.ToDouble(Console.ReadLine());

                Console.Write("What is the value of your family's stock? ");
                stock = Convert.ToDouble(Console.ReadLine());

                value = cash + land + business + stock;

                Console.WriteLine("The asset value of your family is " + value);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }
        
    }
}