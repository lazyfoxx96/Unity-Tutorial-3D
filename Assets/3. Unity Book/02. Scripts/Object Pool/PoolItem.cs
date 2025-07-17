using UnityEngine;

public class PoolItem : MonoBehaviour
{
    private PoolManager poolManager;

    private void Start()
    {
        Invoke("ReturnObject", 3f);
    }

    private void ReturnObject()
    {
        PoolManager.Instance.pool.Release(gameObject);
    }
}
