using System;
using System.Collections;
using UnityEngine;

public class SwingController : MonoBehaviour
{
    private Animator anim;

    public Action onStartSwing;
    public Action onEndSwing;

    private bool isSwing;

    private void Start()
    {
        anim = GetComponent<Animator>();

        onStartSwing += SwingStart;
        onEndSwing += SwingEnd;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(!isSwing)
            {
                StartCoroutine(SwingRoutine(onStartSwing, onEndSwing));
            }
        }
    }

    public IEnumerator SwingRoutine(Action action1, Action action2)
    {
        isSwing = true;
        anim.SetTrigger("Swing");
        //SwingStart();
        action1?.Invoke();

        float animLength = anim.GetCurrentAnimatorStateInfo(0).length; //현재 실행중인 애니메이션의 시간
        yield return new WaitForSeconds(animLength);
        //SwingEnd();
        action2?.Invoke();
    }

    private void SwingStart()
    {
        Debug.Log("스윙 시작");
    }

    private void SwingEnd()
    {
        Debug.Log("스윙 종료");
    }
}
