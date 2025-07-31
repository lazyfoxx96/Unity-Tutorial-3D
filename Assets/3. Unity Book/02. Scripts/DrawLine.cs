using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{
    private LineRenderer line; // 생성된 라인 렌더러
    private int lineCount = 0;
    private int lineObjectCount = 1;

    public Color color; // 라인 색상
    public float lineWidth = 0.05f; // 라인 굵기

    public List<GameObject> lineObjs = new List<GameObject>(); // 생성한 Line이 담길 List

    private void Start()
    {
        color = new Color(1, 1, 1, 1);
    }

    private void Update()
    {
        //Draw Line 시작 / 선 그리기 시작
        if ( Input.GetMouseButtonDown(0))
        {
            GameObject lineObject = new GameObject("Line Object"); // 빈 게임 오브젝트 생성
            lineObjectCount++;

            line = lineObject.AddComponent<LineRenderer>();
            line.useWorldSpace = false;
            line.startWidth = lineWidth;
            line.endWidth = lineWidth;

            line.startColor = color;
            line.endColor = color;

            line.material = new Material(Shader.Find("Universal Render Pipeline/Particles/Unlit"));

            lineObjs.Add(line.gameObject);
        }

        // 선 그리는 중
        if(Input.GetMouseButton(0))
        {
            Vector3 screenPos = Input.mousePosition;
            screenPos.z = 10f;
            Vector3 worldPos = Camera.main.ScreenToWorldPoint(screenPos); // 월드 상에 마우스 위치

            lineCount++;
            line.positionCount = lineCount;
            line.SetPosition(lineCount - 1, worldPos);
        }

        // 선 그리기 종료
        if(Input.GetMouseButtonUp(0))
        {
            lineCount = 0;
        }

        if(Input.GetKeyDown(KeyCode.Space)) 
        {
            foreach (var line in lineObjs)
                Destroy(line);

            lineObjs.Clear();
        }
    }
}
