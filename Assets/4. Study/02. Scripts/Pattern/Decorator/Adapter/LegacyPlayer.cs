using UnityEngine;

public class LegacyPlayer
{
    public void LegacyMove(float x, float y, float z)
    {
        Debug.Log($"Legacy Move : {x}, {y}, {z}");
    }

    public void LegacyAttack()
    {
        Debug.Log($"Legacy Attack");
    }
}
