using UnityEngine;

public class SingletonEx5 : MonoBehaviour
{
    private static SingletonEx5 instance;
    public static SingletonEx5 Instance
    {
        get
        {
            if(instance == null)
            {
                var obj = FindFirstObjectByType<SingletonEx5>();

                if(obj != null)
                {
                    instance = obj;
                }
                else
                {
                    var newObj = new GameObject("Singleton"); // singleton이라는 이름의 오브젝트 생성
                    newObj.AddComponent<SingletonEx5>();

                    instance = newObj.GetComponent<SingletonEx5>();
                }
            }

            return instance;
        }
    }

    private void Awake()
    {
        if(instance == null) // 할달을 해서 실글톤화
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else // 중복 제거
            Destroy(gameObject);
    }

}
