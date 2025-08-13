using UnityEngine;

[CreateAssetMenu(fileName = "WeaponData", menuName = "Scriptable Objects/WeaponData")]
public class WeaponData : ScriptableObject
{
    public string weaponName;
    public int attackDamage;
    public int attackRange;
}

public class MonoClass : MonoBehaviour
{

}