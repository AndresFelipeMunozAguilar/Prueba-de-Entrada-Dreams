using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class ArrayShifting : MonoBehaviour
{
    // Array de números a desplazar
    public int[] numbers = {1, 2, 3, 4}; // Crea e inicializa el arreglo con estos valores

    // Cantidad de posiciones a mover
    public int offset = 4; // Cantidad de posiciones a mover

    void Start() {
        // Llama al método ShiftArray y almacena el resultado
        int[] answer = ShiftArray(numbers, offset);
        
        // Imprime el resultado en la consola
        Debug.Log("==================== Punto 1 ====================\n");
        string result = string.Join(", ", answer);
        Debug.Log(result);
        Debug.Log("\n");
        Debug.Log("==================================================\n");
    }
  
    // Método para desplazar el array por un offset dado
    public int[] ShiftArray(int[] arreglo, int offset) {
        int arrayLength = arreglo.Length;
        
        // Asegura que el offset esté dentro de los límites de la longitud del array
        offset = offset % arrayLength;
        
        // Crea una copia del array original
        int[] answer = arreglo.ToArray();
        
        if (offset > 0) {
            // Desplaza los elementos del array por el offset
            for (int i = 0; i < arrayLength; i++) {
                answer[(offset % arrayLength)] = arreglo[i];
                offset++;
            }
        }
        
        // Retorna el array desplazado
        return answer;
    }
}
