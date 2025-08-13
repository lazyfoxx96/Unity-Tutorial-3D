using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float moveSpeed = 10f;

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        var dir = new Vector3(h, 0, v).normalized;

        transform.position += dir * moveSpeed * Time.deltaTime;
    }
}
