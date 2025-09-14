using UnityEngine;

public class Cha2 : MonoBehaviour
{
    public int numero_1 = 0;

    public int numero_2 = 0;

    public int numero_3 = 0;

    int numero_maior = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (numero_1>numero_2 && numero_1>numero_3)
        {
            numero_maior = numero_1;
        }
        else if (numero_2 > numero_1 && numero_2 > numero_3)
        {
            numero_maior = numero_2;
        }
        else
        {
            numero_maior = numero_3;
        }

        Debug.Log("O maior número é " + numero_maior);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
