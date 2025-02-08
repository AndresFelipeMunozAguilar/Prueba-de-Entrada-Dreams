using UnityEngine;
using System.Collections.Generic;

public class Point4Code : MonoBehaviour
{
    // Declarar una matriz de ejemplo
    public int[,] matrix = {
        {1, 2, 3, 4},
        {5,6,7,8},
        {9,10,11,12},
        {13,14,15,16}
    };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("==================== Punto 4 ====================\n");
        int[] spiralArray = GetSpiralArray(matrix);
        string result = string.Join(", ", spiralArray);
        Debug.Log(result);
        Debug.Log("==================================================\n");
    }

    // Función para obtener los elementos de una matriz en forma de espiral
    public int[] GetSpiralArray(int[,] matrix)
    {
        List<int> result = new List<int>();
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int top = 0;
        int bottom = rows - 1;
        int left = 0;
        int right = cols - 1;

        while (top <= bottom && left <= right)
        {
            // Añadir la fila superior
            for (int i = left; i <= right; i++)
            {
                result.Add(matrix[top, i]);
            }
            top++;

            // Añadir la columna derecha
            for (int i = top; i <= bottom; i++)
            {
                result.Add(matrix[i, right]);
            }
            right--;

            // Añadir la fila inferior
            if (top <= bottom)
            {
                for (int i = right; i >= left; i--)
                {
                    result.Add(matrix[bottom, i]);
                }
                bottom--;
            }

            // Añadir la columna izquierda
            if (left <= right)
            {
                for (int i = bottom; i >= top; i--)
                {
                    result.Add(matrix[i, left]);
                }
                left++;
            }
        }

        return result.ToArray();
    }
}
