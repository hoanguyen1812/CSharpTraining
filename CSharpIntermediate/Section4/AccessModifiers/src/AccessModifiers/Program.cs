using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class GoldCustomer : Customer
    {
        public void OfferVouchar()
        {
            var rating = this.CalculateRating();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            var customer = new Customer();
        }
    }
}
