using UnityEngine;

public class LegacyPlayerAdapter : MonoBehaviour, ICharacter
{
    private LegacyPlayer legacyPlayer;

    void Awake()
    {
        legacyPlayer = new LegacyPlayer();
    }

    public void Move(Vector3 dir)
    {
        legacyPlayer.LegacyMove(dir.x, dir.y, dir.z);
    }

    public void Attack()
    {
        legacyPlayer.LegacyAttack();
    }
}
