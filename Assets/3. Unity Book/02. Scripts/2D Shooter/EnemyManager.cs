using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : Singleton<EnemyManager>
{
    public int poolSize = 10;

    //public GameObject[] enemyObjectPool; 배열
    //public List<GameObject> enemyObjectPool; 리스트
    public Queue<GameObject> enemyObjectPool;
    public Transform[] spawnPoints;

    public float currentTime;// 타이머
    public float createTime = 1f; // 생성 주기

    private float minTime = 1;
    private float maxTime = 5;

    public GameObject enemyFactory;

    private void Start()
    {
        createTime = Random.Range(minTime, maxTime);

        //리스트
        //enemyObjectPool = new List<GameObject>();
        enemyObjectPool = new Queue<GameObject>();

        for(int i = 0; i <  poolSize; i++)
        {
            GameObject enemy = Instantiate(enemyFactory);
            //enemyObjectPool[i] = enemy; 배열
            //enemyObjectPool.Add(enemy); 리스트
            enemyObjectPool.Enqueue(enemy);
            enemy.SetActive(false);

            //enemy.transform.position = transform.position;
        }
    }

    private void Update()
    {
        currentTime += Time.deltaTime;

        if(currentTime > createTime) // 타이머가 생성 주기를 넘었다면
        {
            if(enemyObjectPool.Count > 0)
            {
                currentTime = 0;
                createTime = Random.Range(minTime, maxTime);

                GameObject enemy = enemyObjectPool.Dequeue();

                int ranIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[ranIndex];

                enemy.transform.position = spawnPoint.position;
                enemy.SetActive(true);
            }

            /* 리스트
            if(enemyObjectPool.Count > 0)
            {
                currentTime = 0;
                createTime = Random.Range(minTime, maxTime);

                GameObject enemy = enemyObjectPool[0];
                enemyObjectPool.Remove(enemy);

                int ranIndex = Random.Range(0, spawnPoints.Length);
                Transform spawnPoint = spawnPoints[ranIndex];

                enemy.transform.position = spawnPoint.position;
                enemy.SetActive(true);

            }
            */

            /* 배열
            //for(int i = 0; i < poolSize; i++)
            //{
            //    GameObject enemy = enemyObjectPool[0];
            //    if(!enemy.activeSelf)
            //    {
            //        int ranIndex = Random.Range(0, spawnPoints.Length);
            //        Transform spawnPoint = spawnPoints[ranIndex];

            //        enemy.transform.position = spawnPoint.position;
            //        enemy.SetActive(true);

            //        break;
            //    }
            //}
            */
        }
    }
}
