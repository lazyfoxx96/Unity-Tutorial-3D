using UnityEngine;

public class MochaDecorator : CoffeeDecorator
{
    public MochaDecorator(ICoffee coffee) : base(coffee)
    {

    }

    public override string Name()
    {
        return coffee.Name() + "Mocha";
    }

    public override int Cost()
    {
        return coffee.Cost() + 1000;
    }
}
