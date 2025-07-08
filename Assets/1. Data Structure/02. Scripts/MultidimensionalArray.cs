using UnityEngine;

public class MultidimensionalArray : MonoBehaviour
{
    int[,] array = new int[3, 3]; // 3행 3열을 가진 2차원 배열
    int[,,] array2 = new int[2, 3, 4]; // 3차원 배열

    int[,] matrix = new int[3, 3];

    private void Start()
    {
        matrix[1, 2] = 25;

        Debug.Log(matrix[1, 2]); // 25
    }
}
