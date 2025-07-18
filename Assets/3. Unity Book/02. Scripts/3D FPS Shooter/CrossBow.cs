using System.Collections;
using UnityEngine;

public class CrossBow : MonoBehaviour
{
    /// 화살을 발사하는 기능
    /// - 화살
    /// - 발사할 위치
    /// - 화살이 날아가는 기능 -> Arrow 스크립트 생성
    /// 
    public GameObject arrowPrefab;
    public Transform shootPos;
    public bool isShoot;
    
    /// 누군가를 감지하는 기능 -> 감지하는건 대표적으로 Collider Event(영역 기반), Raycast Event(직선 기반)
    ///  - 직선상으로 감지
    ///  - 감지했을 때 화살을 생성
    ///  - 생성한 화살이 날아감

    private void Update()
    {
        Ray ray = new Ray(shootPos.position, shootPos.forward);
        RaycastHit hit; // 레이저 닿은 대상

        bool isTargeting = Physics.Raycast(ray, out hit);

        Debug.DrawRay(shootPos.position, shootPos.forward, Color.green);

        if (isTargeting && !isShoot) // bool = true / false
        {
            StartCoroutine(ShootRoutine());

        }
    }

    IEnumerator ShootRoutine()
    {
        isShoot = true;
        // 화살 생성
        // 화살 위치 설정
        GameObject arrow = Instantiate(arrowPrefab, transform);

        Quaternion rot = Quaternion.Euler(new Vector3(90, 0, 0));
        arrow.transform.SetPositionAndRotation(shootPos.position, rot);

        yield return new WaitForSeconds(3f);
        isShoot = false;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(shootPos.position, shootPos.forward);
    }
}
