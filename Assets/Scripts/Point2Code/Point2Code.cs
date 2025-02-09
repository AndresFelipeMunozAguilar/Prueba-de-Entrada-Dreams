using UnityEngine;

public class Point2Code : MonoBehaviour
{

    public int radCircle1 = 1;

    public int[] positionCircle1 = { 0, 0 };
    public int radCircle2 = 3;
    public int[] positionCircle2 = { 0, 3 };

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bool collision = CheckCollision(radCircle1, positionCircle1, radCircle2, positionCircle2);

        Debug.Log("==================== Punto 2 ====================\n");
        Debug.Log("Hay Colision?: " + collision);
        Debug.Log("==================================================\n");
    }

    public bool CheckCollision(int radCircle1, int[] positionCircle1, int radCircle2, int[] positionCircle2)
    {

        bool collision = false;
        // Calcular la distancia entre los dos círculos
        float distanceBetweenCircles = Mathf.Sqrt(Mathf.Pow(positionCircle2[0] - positionCircle1[0], 2) + Mathf.Pow(positionCircle2[1] - positionCircle1[1], 2));

        // Si la distancia es menor o igual a la suma de los radios, hay colisión
        if (distanceBetweenCircles <= (radCircle1 + radCircle2))
        {
            collision = true;

        }
    
        // De lo contrario, no hay colisión
        return collision;


    }
}
