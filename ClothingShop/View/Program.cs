using BusinessLayer;
using DataAccessLayer;

namespace View
{
    internal class Program
    {
        static void Main()
        {
            Context context = new Context();
            List<Clothing> cart = context.Clothes.ToList();
            Cashier.PrintReceipt(cart, DateTime.UtcNow);
        }
    }
}