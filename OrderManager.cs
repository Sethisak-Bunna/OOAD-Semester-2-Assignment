using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project
{
    public class OrderManager
    {
        private static OrderManager _instance;
        private static readonly object _lock = new object();
        private List<Drink> _drinks = new List<Drink>();

        private OrderManager() { }

        public static OrderManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new OrderManager();
                        }
                    }
                }
                return _instance;
            }
        }

        public void AddDrink(Drink drink) => _drinks.Add(drink);

        public double GetTotalCost() => _drinks.Sum(d => d.Cost);

        public List<Drink> GetDrinks() => _drinks;
    }
}
