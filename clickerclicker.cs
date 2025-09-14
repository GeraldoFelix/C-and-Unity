using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;

public class clickerclicker : MonoBehaviour
{



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    int recurso = 0;

    int clique = 1;

    public Text contador;
    public void botao ()
    {
        recurso = Random.Range(0, 10);
        contador.text = recurso.ToString();
    }

    public void upgrade_1 (int custo)
    {
        if (recurso >= custo)
        {
            Debug.Log("Comprado");
            recurso -= custo;
            clique = clique * (custo / 10);
            custo = custo + 20;
        }
        else
        {
            Debug.Log("Você não tem recurso o suficiente, lhe falta: " + (custo - recurso));
        }
  
    }
}
