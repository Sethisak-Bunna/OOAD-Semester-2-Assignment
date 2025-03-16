using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project
{
    public interface IDiscountStrategy
    {
        double ApplyDiscount(double total);
    }

    public class NoDiscount : IDiscountStrategy
    {
        public double ApplyDiscount(double total) => total;
    }

    public class BulkPurchaseDiscount : IDiscountStrategy
    {
        public int Quantity { get; set; } // Track the quantity of drinks purchased

        public double ApplyDiscount(double total)
        {
            if (Quantity >= 5)
            {
                return total * 0.9; // 10% discount
            }
            return total; // No discount if less than 5 drinks
        }
    }
}