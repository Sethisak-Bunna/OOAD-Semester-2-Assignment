using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project
{
    public class Order
    {
      
        public string DrinkName { get; set; }
        public decimal DrinkPrice { get; set; }
        public string Toppings { get; set; }
        public decimal ToppingPrice { get; set; }
        public decimal TotalPrice { get; set; }

        public override string ToString()
        {
            return $"{DrinkName} - ${TotalPrice:F2}";
        }
    }
}
