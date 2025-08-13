using UnityEngine;

public class StudyDelegate : MonoBehaviour
{
    public delegate void TimerStart();
    public TimerStart onTimerStart;

    public delegate void TimerEnd();
    public TimerEnd onTimerEnd;

    private float timer = 5f;
    private bool isTimer = true;

    void OnEnable()
    {
        onTimerStart += StartEvent;
        onTimerEnd += EndEvent;
    }

    void Start()
    {
        onTimerStart?.Invoke();
    }

    void OnDisable()
    {
        onTimerStart -= StartEvent;
        onTimerEnd -= EndEvent;
    }

    void Update()
    {
        if (!isTimer)
            return;

        timer -= Time.deltaTime;

        if (timer <= 0f)
        {
            isTimer = false;
            onTimerEnd?.Invoke();
        }
    }

    private void StartEvent()
    {
        Debug.Log("타이머 시작");
    }

    private void EndEvent()
    {
        Debug.Log("타이머 종료");
    }
}
