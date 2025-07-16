using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public float currentTime;// 타이머
    public float createTime = 1f; // 생성 주기

    private float minTime = 1;
    private float maxTime = 5;

    public GameObject enemyFactory;

    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime) // 타이머가 생성 주기를 넘었다면
        {
            GameObject enemy = Instantiate(enemyFactory);
            enemy.transform.position = transform.position;

            currentTime = 0;
        }
    }
}
