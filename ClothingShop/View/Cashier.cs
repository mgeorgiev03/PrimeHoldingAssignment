using BusinessLayer;

namespace View
{
    internal class Cashier
    {
        public static void PrintReceipt(List<Clothing> clothes, DateTime currentDate)
        {
            Console.WriteLine("Date: {0}-{1}-{2} {3}:{4}:{5}", currentDate.Year, currentDate.Month, currentDate.Day,
                currentDate.Hour, currentDate.Minute, currentDate.Second);

            double totalPrice = 0;
            double totalDiscount = 0;
            double totalPriceToPay= 0;

            Console.WriteLine("---Products---");
            foreach (var item in clothes)
            {

                double discount = 0;
                bool isTuesdayShirtDiscountApplicable = false;
                bool isTuesdayShoesDiscountApplicable = false;
                bool is3ItemDiscountApplicable = false;

                //checking whether each discount is applicable
                if (item.Type == ClothingType.Shirt && currentDate.DayOfWeek == DayOfWeek.Tuesday)
                    isTuesdayShirtDiscountApplicable = true;
                else if (item.Type == ClothingType.Shoes && currentDate.DayOfWeek == DayOfWeek.Tuesday)
                    isTuesdayShoesDiscountApplicable = true;

                if (clothes.Count >= 3)
                    is3ItemDiscountApplicable = true;

                //checking which discount is the biggest and is applicable to the product 
                if (is3ItemDiscountApplicable)
                {
                    if (isTuesdayShirtDiscountApplicable)
                        is3ItemDiscountApplicable = false;
                    else if (isTuesdayShoesDiscountApplicable)
                        is3ItemDiscountApplicable = false;
                    else
                    {
                        isTuesdayShoesDiscountApplicable = false;
                        isTuesdayShirtDiscountApplicable = false;
                    }
                }

                //knowing which discount is applicable, discount is calculated
                if (is3ItemDiscountApplicable)
                    discount = item.Price * 1 / 5;
                else if (isTuesdayShirtDiscountApplicable || isTuesdayShoesDiscountApplicable)
                    discount = item.Price * 1 / 4;

                Console.WriteLine("{0} - {1}", item.Name, item.Brand);
                Console.WriteLine("${0}", item.Price);
                Console.WriteLine("#discount {0}% - {1} (if applicable)", discount / item.Price * 100, discount);

                totalPrice += item.Price;
                totalDiscount += discount;
                totalPriceToPay += item.Price - discount;
            }

            Console.WriteLine("-------------------------------");

            Console.WriteLine("SUBTOTAL: {0}", totalPrice);
            Console.WriteLine("DISCOUNT: {0}", totalDiscount);
            Console.WriteLine("TOTAL: {0}", totalPriceToPay);

        }
    }
}
