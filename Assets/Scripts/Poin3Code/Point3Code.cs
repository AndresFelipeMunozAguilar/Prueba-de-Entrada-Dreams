using UnityEngine;
using System.Collections.Generic;

public class Point3Code : MonoBehaviour
{
    // Declarar un arreglo de arreglos de enteros
    public int[][] matrix = {
        new int[] {1, 1, 1, 1},
        new int[] {0, 0, 1, 0},
        new int[] {1, 1, 1, 1},
        new int[] {0, 1, 1, 0},
        new int[] {0, 0, 0, 0}
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int[][] answer = EliminateOnesRows(matrix);

        Debug.Log("==================== Punto 3 ====================\n");
        for (int i = 0; i < answer.Length; i++)
        {
            string row = string.Join(", ", answer[i]);
            Debug.Log(row);
        }
        Debug.Log("==================================================\n");
    }

    public int[][] EliminateOnesRows(int[][] matrix)
    {
        List<int[]> result = new List<int[]>();

        for (int i = 0; i < matrix.Length; i++)
        {
            if (!isRowFullOfOnes(matrix[i]))
            {
                result.Add(matrix[i]);
            }
        }

        return result.ToArray();
    }

    public bool isRowFullOfOnes(int[] row)
    {
        bool hasOnes = true;
        for (int i = 0; i < row.Length; i++)
        {
            if (row[i] != 1)
            {
                hasOnes = false;
            }
        }
        return hasOnes;
    }
}
