#define DEBUG_TEST

using System.Collections.Generic;
using UnityEngine;

public class PlayerFire : Singleton<PlayerFire>
{
    public GameObject bulletFactory;
    public GameObject firePosition;

    public int poolSize = 10;
    //public GameObject[] bulletObjectPool; // 배열
    //public List<GameObject> bulletObjectPool; //리스트
    public Queue<GameObject> bulletObjectPool; // 큐

    private void Start()
    {
        //bulletObjectPool = new GameObject[poolSize];
        bulletObjectPool = new Queue<GameObject>();

        for (int i = 0; i < poolSize; i++)
        {
            GameObject bullet = Instantiate(bulletFactory);
            //bulletObjectPool[i] = bullet; // 배열
            //bulletObjectPool.Add(bullet); // 리스트
            bulletObjectPool.Enqueue(bullet); // 큐
            bullet.SetActive(false);
        }
    }

    //private void Start()
    //{
    //    bulletFactory = Resources.Load<GameObject>("Bullet");
    //}

    private void Update()
    {
        //전처리문
#if UNITY_STANDALONE || UNITY_EDITOR || DEBUG_TEST
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("마우스 클릭");

            //큐 방식
            if (bulletObjectPool.Count > 0)
            {
                GameObject bullet = bulletObjectPool.Dequeue();
                bullet.SetActive(true);
                bullet.transform.position = firePosition.transform.position;
            }

            /* 리스트 방식
            if(bulletObjectPool.Count > 0)
            {
                GameObject bullet = bulletObjectPool[0]; // 가져올 오브젝트 선택
                bullet.SetActive(true); // 오브젝트 사용

                bulletObjectPool.Remove(bullet); // Pool에서 오브젝트 제거
                bullet.transform.position = firePosition.transform.position;
            }
            */
        }
#elif UNITY_ANDROID

            
            for (int i = 0; i < poolSize; i++)
            {
                GameObject bullet = bulletObjectPool[i];

                if(!bullet.activeSelf) // 선택한 총알 오브젝트가 비활성화 상태인지 확인
                {
                    bullet.SetActive(true);
                    bullet.transform.position = firePosition.transform.position;

                    break;
                }
            }

            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position; // 위치 초기화
            bullet.transform.rotation = firePosition.transform.rotation; // 회전 초기화

            bullet.transform.SetPositionAndRotation(transform.position, Quaternion.identity); // 위치와 회전을 한번에 적용하는 기능
            bullet.transform.SetParent(부모);
            
#else
    Debug.log("그 외 나머지 플랫폼");

        

#endif
    }
}
