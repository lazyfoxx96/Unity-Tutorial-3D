using System;
using UnityEngine;

public static class StudyEventBus
{
    public static event Action onStart;
    public static event Action<int> onScoreChanged;

    public static void StartEvent()
    {
        onStart?.Invoke();
    }

    public static void ScoreChange(int newScore)
    {
        onScoreChanged.Invoke(newScore);
    }
}
