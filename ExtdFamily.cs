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
    }          
}