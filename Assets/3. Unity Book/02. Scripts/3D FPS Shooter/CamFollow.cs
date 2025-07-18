using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform Target;

    private void Update()
    {
        transform.position = Target.position;
    }
}
