using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Pattern_Project
{
    public abstract class Drink
    {
        public abstract string Description { get; }
        public abstract double Cost { get; }
    }

    public class Americano : Drink
    {
        public override string Description => "Americano";
        public override double Cost => 2.00;
    }

    public class IceMatcha : Drink
    {
        public override string Description => "Ice Matcha Latte";
        public override double Cost => 4.00;
    }

    public class PassionMangoTea : Drink
    {
        public override string Description => "Passion Mango Tea";
        public override double Cost => 2.50;
    }
    public class MilkTea : Drink
    {
        public override string Description => "Milk Tea";
        public override double Cost => 2.80;
    }

    public class JasmineTea : Drink
    {
        public override string Description => "Jasmine Tea";
        public override double Cost => 1.50;
    }

    public static class DrinkFactory
    {
        public static Drink CreateDrink(string type)
        {
            switch (type)
            {
                case "Americano":
                    return new Americano();
                case "Ice Matcha Latte":
                    return new IceMatcha();
                default:
                case "Passion Mango Tea":
                    return new PassionMangoTea();
                case "Milk Tea":
                    return new MilkTea();
                case "Jasmine Tea":
                    return new JasmineTea();
                    throw new ArgumentException("Unknown drink type");
            }
        }
    }
}
