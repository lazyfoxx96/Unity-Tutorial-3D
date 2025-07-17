using UnityEngine;

public class SingletonEx3 : MonoBehaviour
{

    //즉시 초기화 -> 좋지않은 방법
    private static SingletonEx3 instance = new SingletonEx3();
    public static SingletonEx3 Instance
    {
        get
        {
            if(instance == null)
            {
                instance = new SingletonEx3();
            }

            return instance;
        }
    }
}
