using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project
{
    public abstract class DrinkDecorator : Drink
    {
        protected Drink _drink;

        protected DrinkDecorator(Drink drink) => _drink = drink;
    }

    public class BobaDecorator : DrinkDecorator
    {
        public BobaDecorator(Drink drink) : base(drink) { }

        public override string Description => $"{_drink.Description}, Boba(0.70)";
        public override double Cost => _drink.Cost + 0.70;
    }

    public class JellyDecorator : DrinkDecorator
    {
        public JellyDecorator(Drink drink) : base(drink) { }

        public override string Description => $"{_drink.Description}, Jelly(0.50)";
        public override double Cost => _drink.Cost + 0.50;
    }
}
