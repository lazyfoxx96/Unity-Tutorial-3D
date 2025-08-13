using UnityEngine;

public class QuestSystem : MonoBehaviour
{
    public void StartQuest(string questName)
    {
        Debug.Log($"{questName} 획득");
    }

    public void HasQuest(string questName)
    {
        Debug.Log($"{questName} 유무");
    }

    public void CompleteQuest(string questName)
    {
        Debug.Log($"{questName} 완료");
    }
}
