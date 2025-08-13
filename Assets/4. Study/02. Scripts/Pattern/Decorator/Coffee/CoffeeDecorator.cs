using UnityEngine;

public class CoffeeDecorator : ICoffee
{
    protected ICoffee coffee;

    public CoffeeDecorator(ICoffee coffee)
    {
        this.coffee = coffee;
    }

    public virtual string Name()
    {
        return coffee.Name();
    }

    public virtual int Cost()
    {
        return coffee.Cost();
    }
}
