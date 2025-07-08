using UnityEngine;

public class StudyString : MonoBehaviour
{
    public string str1 = " Hello World***";

    public string[] str2 = new string[3] { "Hello", "Unity", "World" };

    private void Start()
    {
        /* debug
        //Debug.Log(str1[0]);
        //Debug.Log(str1[2]);

        //Debug.Log(str2[0]);
        //Debug.Log(str2[2]);

        //Debug.Log(str1.Length);
        //Debug.Log(str1.Trim());
        //Debug.Log(str1.Trim('*'));

        Debug.Log(str1.Contains('H'));
        Debug.Log(str1.Contains('h'));
        Debug.Log(str1.Contains("Hello"));

        Debug.Log(str1.ToUpper());
        Debug.Log(str1.ToLower());
        

        Debug.Log(str1.Replace("World", "Unity"));
        str1 = str1.Replace("World", "Unity");

        Debug.Log(str1);
        */

        string text = "Apple,Banana,Orange,Melon,Water Melon,Mango";
        string[] fruits = text.Split(',');
        
        foreach (var fruit in fruits)
            Debug.Log(fruit);
    }
}
