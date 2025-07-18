using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial;

    public float scrollSpeed = 0.2f;

    private void Update()
    {
        Vector2 diraction = Vector2.up;

        bgMaterial.mainTextureOffset += diraction * scrollSpeed * Time.deltaTime;
    }
}
