using System.Collections.Generic;
using UnityEngine;

public class StudyQueue : MonoBehaviour
{
    public Queue<int> queue = new Queue<int>();

    private void Start()
    {
        for(int i= 1; i<= 10; i++)
        {
            queue.Enqueue(i);
        }

        int output = queue.Dequeue(); // 값 뽑기
        Debug.Log(output);

        Debug.Log(queue.Peek()); // 다음에 뽑을 값 확인

        Debug.Log(queue.Contains(5)); // 값 5가 포함되어있는지 확인 true or false

        queue.Clear(); // 모든 값 삭제

        Debug.Log(queue.Count); // 갯수 확인

    }
}
