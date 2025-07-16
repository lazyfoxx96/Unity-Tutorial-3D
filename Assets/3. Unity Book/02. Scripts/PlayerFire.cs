using Unity.VisualScripting;
using UnityEngine;

public class PlayerFire : MonoBehaviour
{
    public GameObject bulletFactory;
    public GameObject firePosition;

    //private void Start()
    //{
    //    bulletFactory = Resources.Load<GameObject>("Bullet");
    //}

    private void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(bulletFactory);
            bullet.transform.position = firePosition.transform.position; // 위치 초기화
            //bullet.transform.rotation = firePosition.transform.rotation; // 회전 초기화

            //bullet.transform.SetPositionAndRotation(transform.position, Quaternion.identity); // 위치와 회전을 한번에 적용하는 기능
            //bullet.transform.SetParent(부모);
        }
    }
}
