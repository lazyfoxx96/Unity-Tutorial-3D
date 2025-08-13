using UnityEngine;

namespace Pattern
{
    public class ScoreManager : MonoBehaviour
    {
        private void OnEnable()
        {
            StudyEventBus.onScoreChanged += UpdateScore;
        }

        private void OnDisable()
        {
            StudyEventBus.onScoreChanged -= UpdateScore;
        }

        public void UpdateScore(int newScore)
        {
            Debug.Log($"현재 점수 : {newScore}");
        }
    }
}


