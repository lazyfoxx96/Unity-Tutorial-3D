using UnityEngine;

namespace Pattern
{

public class ScoreController : MonoBehaviour
{
    private int score = 0;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            score++;
            StudyEventBus.ScoreChange(score);
        }
    }
}


}
