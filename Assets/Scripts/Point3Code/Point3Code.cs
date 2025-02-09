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

    // Start se llama una vez antes de la primera ejecución de Update después de que se crea el MonoBehaviour
    void Start()
    {
        int[][] answer = EliminateOnesRows(matrix);

        Debug.Log("==================== Punto 3 ====================\n");
        for (int i = 0; i < answer.Length; i++)
        {
            string row = string.Join(", ", answer[i]);
            // Imprimir cada fila de la matriz resultante
            Debug.Log(row);
        }
        Debug.Log("==================================================\n");
    }

    // Método para eliminar filas que están completamente llenas de unos
    public int[][] EliminateOnesRows(int[][] matrix)
    {
        List<int[]> result = new List<int[]>();

        // Iterar sobre cada fila de la matriz
        for (int i = 0; i < matrix.Length; i++)
        {
            // Si la fila no está completamente llena de unos, añadirla al resultado
            if (!isRowFullOfOnes(matrix[i]))
            {
                result.Add(matrix[i]);
            }
        }

        // Convertir la lista de resultados a un arreglo de arreglos y devolverlo
        return result.ToArray();
    }

    // Método para verificar si una fila está completamente llena de unos
    public bool isRowFullOfOnes(int[] row)
    {
        bool hasOnes = true;
        // Iterar sobre cada elemento de la fila
        for (int i = 0; i < row.Length; i++)
        {
            // Si algún elemento no es uno, establecer hasOnes a false
            if (row[i] != 1)
            {
                hasOnes = false;
            }
        }
        // Devolver el resultado de la verificación
        return hasOnes;
    }
}
