using UnityEngine;

public class DestoryZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name.Contains("Bullet"))
        { 
            //리스트
            //PlayerFire.Instance.bulletObjectPool.Add(other.gameObject);
            //큐
            PlayerFire.Instance.bulletObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false);
        }
        else
        {
            // 리스트
            //EnemyManager.Instance.enemyObjectPool.Add(other.gameObject);
            // 큐
            EnemyManager.Instance.enemyObjectPool.Enqueue(other.gameObject);
            other.gameObject.SetActive(false); // 총알, Enemy 오브젝트
        }
    }
}
