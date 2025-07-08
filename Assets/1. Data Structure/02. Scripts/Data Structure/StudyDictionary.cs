using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonData
{
    public int age;
    public string name;
    public float height;
    public float weight;

    public PersonData(int age, string name, float height, float weight)
    {
        this.age = age;
        this.name = name;
        this.height = height;
        this.weight = weight;
    }
}

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, PersonData> persons = new Dictionary<string, PersonData>();

    private void Start()
    {
        persons.Add("철수", new PersonData(15, "철수", 170f, 60f));
        persons.Add("영희", new PersonData(15, "영희", 170f, 60f));
        persons.Add("동수", new PersonData(15, "동수", 170f, 60f));

        Debug.Log(persons["철수"].age);
        Debug.Log(persons["철수"].name);
        Debug.Log(persons["철수"].height);
        Debug.Log(persons["철수"].weight);

        Hashtable h_nameAges = new Hashtable();

//추가
        h_nameAges["철수"] = 10;
        h_nameAges["영수"] = "20"; // 다른 타입 저장 가능 (비효율적)

//데이터 출력 -> 캐스팅 필요
        int score = (int)h_nameAges["철수"];

//삭제
        h_nameAges.Remove("Player2");

        if (h_nameAges.ContainsKey("철수"))
        {
            Debug.Log("HashTable에 철수가 있음.");
        }
    }
}
