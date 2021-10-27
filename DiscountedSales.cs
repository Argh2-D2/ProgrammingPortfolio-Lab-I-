using System;

namespace L1._6_DiscountedSalesPrice
{
    class Program    
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Enter product name.");
           string productname = Console.ReadLine();

           Console.WriteLine("Enter discounted price.");
           int discount = int.Parse(Console.ReadLine());

           Console.WriteLine("Enter orginal sales price.");
           decimal originalPrice = decimal.Parse(Console.ReadLine());

           decimal discountPrice = originalPrice - (discount/100m * originalPrice);

           Console.WriteLine("Product: " + productname);
           Console.WriteLine("Original Price:" + originalPrice.ToString("C2"));
           Console.WriteLine("At a discount of " + discount + "%, the discounted price is " + discountPrice.ToString("C2"))
               
        }
    }
}
