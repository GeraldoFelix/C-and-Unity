using JetBrains.Annotations;
using UnityEngine;

public class cha4NEW : MonoBehaviour
{

    public int lado1 = 0;
    public int lado2 = 0;
    public int lado3 = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (lado1 == lado2 && lado2 == lado3)
        {
            Debug.Log("Seu tri�ngulo � Equil�tero");
        }
        else if (lado1 == lado2 || lado2 == lado3 || lado3== lado1)
        {
            Debug.Log("Seu tri�nglo � is�sceles");
        }
        else
        {
            Debug.Log("Seu tri�ngulo � Escaleno");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
