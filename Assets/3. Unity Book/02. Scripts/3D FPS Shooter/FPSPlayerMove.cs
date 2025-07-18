using NUnit.Framework.Interfaces;
using UnityEditor.UIElements;
using UnityEngine;

public class FPSPlayerMove : MonoBehaviour
{
    private CharacterController cc;

    public float moveSpeed = 7f;

    private float gravity = -20f;
    private float yVelocity = 0f;

    public float jumpPower = 10f;
    public bool isJumping = false;


    private void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    private void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        Vector3 dir = new Vector3(h, 0, v); // 크기와 방향이 있는 벡터
        dir = dir.normalized; // 방향만 있는 벡터

        // 카메라의 transform 기준으로 변환
        dir = Camera.main.transform.TransformDirection(dir);

        //중력 적용
        yVelocity += gravity * Time.deltaTime;
        dir.y = yVelocity;

        cc.Move(dir * moveSpeed * Time.deltaTime); // 캐릭터 컨트롤러에 내장된 이동 기능

        // None : 아무것도 닿지 않은 상태 , Sides : 옆면에 무엇인가 닿은 상태, Above : 머리에 무엇인가 닿은 상태, Below : 아래쪽에 무엇인가 닿은 상태
        if (cc.collisionFlags == CollisionFlags.Below) // Below : 아래쪽에 무엇인가 닿은 상태
        {
            if(isJumping)
            {
                isJumping = false;
            }
            yVelocity = 0;
        }

        if(Input.GetButtonDown("Jump") && !isJumping) // 2단 점프 방지
        {
            isJumping = true;
            yVelocity = jumpPower; // 점프하는 순간 yVelocity 초기화
        }
    }
}
