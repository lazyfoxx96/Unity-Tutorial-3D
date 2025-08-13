using UnityEngine;

public class StudyState : MonoBehaviour
{
    public IState state = new IdelState();

    private void Update()
    {
        state?.StateUpdate();
    }

    public void SetState(IState newState)
    {
        if(state != newState)
            state = newState;
    }
}
