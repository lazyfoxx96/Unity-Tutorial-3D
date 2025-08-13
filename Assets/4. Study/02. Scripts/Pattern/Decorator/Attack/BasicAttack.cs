using Pattern.Decorator;
using UnityEngine;

public class BasicAttack : IAttack
{
    public void Execute()
    {
        Debug.Log("기본 공격 실행");
    }
}
