using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DynamicArray : MonoBehaviour
{
    public List<int> list1 = new List<int>();

    void Start()
    {
        for(int i=1; i <= 10; i++)
        {
            list1.Add(i);
        }

        //list1.Insert(5, 100);

        //list1.Remove(5); // 값 '5'를 제거

        //list1.RemoveAt(5); // 인덱스 5번을 제거

        //list1.RemoveRange(1, 3);

        //list1.Clear();

        //list1.RemoveAll(x => x > 5);

        list1.Sort();
    }


    
}
