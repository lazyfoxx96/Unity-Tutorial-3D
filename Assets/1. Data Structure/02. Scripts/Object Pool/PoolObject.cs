using UnityEngine;

public class PoolObject : MonoBehaviour
{
    private ObjectPoolQueue pool;

    private void Awake()
    {
        pool = FindFirstObjectByType<ObjectPoolQueue>();
    }

    private void OnEnable()
    {
        Invoke("ReturnPool", 3f);
    }

    private void ReturnPool()
    {
        pool.EnqueueObject(gameObject);
    }
}
