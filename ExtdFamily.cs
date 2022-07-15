using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    public class ExtdFamily : Family
    {
        private string king;
         public ExtdFamily(string king, string queen, string princess, string prince) : base(king,queen,princess,prince)
         {
            this.king = king;
         }

         public override void AssetValue()
        {
            float cash;
            float land;
            float business;
            float stock;
            float value;

            try
            {
                Console.Write("How much money does your family have in the bank? ");
                cash = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the value of the real estate your family has? ");
                land = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the shareholder equity of your family business? ");
                business = Convert.ToInt32(Console.ReadLine());

                Console.Write("What is the value of your family's stock? ");
                stock = Convert.ToInt32(Console.ReadLine());

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