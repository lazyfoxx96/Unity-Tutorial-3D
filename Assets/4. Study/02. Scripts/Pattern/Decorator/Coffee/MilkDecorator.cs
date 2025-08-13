using UnityEngine;

public class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee coffee) : base(coffee)
    {

    }

    public override string Name()
    {
        return coffee.Name() + "Milk";
    }

    public override int Cost()
    {
        return coffee.Cost() + 500;
    }
}
