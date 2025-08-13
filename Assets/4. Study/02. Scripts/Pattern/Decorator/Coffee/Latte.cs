using UnityEngine;

public class Latte : ICoffee
{
    public string Name()
    {
        return "Latte";
    }

    public int Cost()
    {
        return 5500;
    }
}
