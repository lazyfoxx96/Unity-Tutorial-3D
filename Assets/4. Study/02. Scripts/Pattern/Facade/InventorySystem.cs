using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public void AddItem(string itemName)
    {
        Debug.Log($"{itemName} 획득");
    }

    public void HasItem(string itemName)
    {
        Debug.Log($"{itemName} 장착");
    }

    public void RemoveItem(string itemName)
    {
        Debug.Log($"{itemName} 버림");
    }
}
