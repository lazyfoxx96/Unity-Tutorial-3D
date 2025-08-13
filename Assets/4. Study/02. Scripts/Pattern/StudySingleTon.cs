using UnityEngine;

public class StudySingleTon : MonoBehaviour
{
    public static StudySingleTon Instance { get; private set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}