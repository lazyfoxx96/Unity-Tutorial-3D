using UnityEngine;

public class Factorial : MonoBehaviour
{
    private void Start()
    {
        for(int i = 0; i < 10; i++)
            Debug.Log(FactorialFunction(i));
    }

    private int FactorialFunction(int n)
    {
        if (n == 0)
            return 1;

        int result = n * FactorialFunction(n-1);

        return result;
    }
}
