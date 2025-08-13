using UnityEngine;

public class Espresso : ICoffee
{
    public string Name()
    {
        return "Espresso";
    }

    public int Cost()
    {
        return 4000;
    }
}
