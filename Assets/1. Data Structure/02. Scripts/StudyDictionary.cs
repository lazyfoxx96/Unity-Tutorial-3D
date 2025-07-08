using System.Collections.Generic;
using System.IO.Pipes;
using UnityEngine;

public class StudyDictionary : MonoBehaviour
{
    public Dictionary<string, int> persons = new Dictionary<string, int>();

    private void Start()
    {
        persons.Add("ö��", 10);
        persons.Add("����", 15);
        persons.Add("����", 17);

        int age = persons["ö��"];
        Debug.Log($"ö���� ���̴� {age}�Դϴ�.");

        string name;

        foreach( var person in persons )
        {
            if(person.Value == 15)
            {
                Debug.Log($"���̰� 15�� ����� �̸��� {person.Key}�Դϴ�.");
            }

            if(persons.ContainsKey("ö��"))
            {
                Debug.Log("��� �߿� ö���� ����");
                Debug.Log($"{person.Key}�� ���̴� {person.Value}�Դϴ�.");
            }

            if(persons.ContainsValue(17))
            {
                Debug.Log("��� �߿� 17���� ����� ����");
                Debug.Log($"{person.Key}�� ���̴� {person.Value}�Դϴ�.");
            }
        }
    }
}
