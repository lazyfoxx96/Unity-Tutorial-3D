using System;
using UnityEngine;

public class Crop : MonoBehaviour
{
    [SerializeField] private string name;
    public Sprite icon;

    public Action useAction;

    private void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("ㅇㅅㅇ!!!OnTriggerEnter");
        Debug.Log($"{other.transform.name}");
        if (other.CompareTag("Player"))
        {
            Debug.Log("ㅇㅅㅇ!!!get");
            Get();
        }
    }

    public void Get()
    {
        // 인벤토리에 작물 추가

        if (GameManager.Instance.item.CheckItemCount())
        {
            GameManager.Instance.item.GetItem(this);
            Debug.Log($"{name}을 획득하였습니다.");
            gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("인벤토리가 가득 찼습니다.");
        }
    }

    public void Use()
    {
        Debug.Log($"{name}을 사용했습니다.");

        // 체력이나 스테미너를 회복
        // 인벤토리에서 버튼을 눌렀을 때 실행되는 기능
    }
}
