using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class StudyObjectPool : StudyGenericSingleton<StudyObjectPool>
{
    public Queue<GameObject> objQueue = new Queue<GameObject>(); // 오브젝트가 들어갈 풀
    public GameObject objPrefab; // 생성될 오브젝트

    public int poolSize = 500;

    void Start()
    {
        CreateObject();
    }

    private void CreateObject()
    {
        for (int i = 0; i < poolSize; i++)
        {
            GameObject newObj = Instantiate(objPrefab, transform);
            EnqueueObject(newObj);
        }
    }

    public void EnqueueObject(GameObject obj) // 오브젝트를 넣는 기능
    {
        objQueue.Enqueue(obj);
        obj.SetActive(false);
    }

    public GameObject DequeueObject() // 오브젝트를 뽑는 기능
    {
        GameObject obj = objQueue.Dequeue();

        return obj;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (objQueue.Count < 10)
                CreateObject();

            GameObject obj = DequeueObject(); // 풀에서 오브젝트를 뽑아서 사용
            obj.transform.SetPositionAndRotation(transform.position, Quaternion.identity);
        }
    }
}
