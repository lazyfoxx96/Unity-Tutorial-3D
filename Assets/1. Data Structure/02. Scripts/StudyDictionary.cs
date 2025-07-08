using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class StudyDictionary : MonoBehaviour
{
    //커밋되돌리기

    public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        persons.Add("철수", 10);
        persons.Add("영희", 15);
        persons.Add("동수", 17);

        int age = persons["철수"];
        Debug.Log($"철수의 나이는 {age}입니다.");

        string name;

        foreach( var person in persons )
        {
            if(person.Value == 15)
            {
                Debug.Log($"나이가 15인 사람의 이름은 {person.Key}입니다.");
            }

            if(persons.ContainsKey("철수"))
            {
                Debug.Log("사람 중에 철수가 있음");
                Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");
            }

            if(persons.ContainsValue(17))
            {
                Debug.Log("사람 중에 17살인 사람이 있음");
                Debug.Log($"{person.Key}의 나이는 {person.Value}입니다.");
            }
        }
    }
}
