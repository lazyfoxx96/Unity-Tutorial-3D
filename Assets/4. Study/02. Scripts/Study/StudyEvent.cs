using UnityEngine;

public class StudyEvent : MonoBehaviour
{
    public delegate void InputKeyHandler(string msg);
    public InputKeyHandler onInputKey;

    void Start()
    {
        onInputKey += InputKeyEvent;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            onInputKey?.Invoke("DD");
        }
    }

    private void InputKeyEvent(string msg)
    {
        Debug.Log(msg);
    }
}
