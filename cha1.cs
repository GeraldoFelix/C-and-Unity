using UnityEngine;

public class Chanlllger : MonoBehaviour
{
    public int x = 0;

    public int y = 0;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int soma = x + y;

        Debug.Log("A soma de " + x + " + " + y + " é igual a " + soma);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
