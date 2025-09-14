using System;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class cha5 : MonoBehaviour
{

    public InputField nome_jogador1;

    public InputField mao_jogador_1;

    public InputField jogador1_escolher_impar_ou_par;

    public Text nome_jogador2;

    public Text mao_jogador_2;

    public Text vencedor;

    public void Jogar()
    {
        string nome1 = nome_jogador1.text;

        int numero1 = int.Parse(mao_jogador_1.text);

        string IP = jogador1_escolher_impar_ou_par.text;

        string nome_jogador_2 = nome_jogador2.text;

        int numero_jogador2 = num_aleatorio();

        string vencedor_jogo = vencedor.text;

        int soma = numero1 + numero_jogador2;

        Quem_vence(soma, IP);
    } 
    
    int num_aleatorio()
    {
        int aleatorio = Random.Range(0, 6);

        return aleatorio;
    }

    string Quem_vence(soma)
    {
        if (soma % 2 == 0 && jogador1_escolher_impar_ou_par == false)
        {
            Debug.Log(soma + " é um número par, portanto " + jogador_1 + " venceu!");

        }
        else if (soma % 2 == 1 && jogador1_escolher_impar_ou_par == true)
        {
            Debug.Log(soma + " é um número ímpar, portanto " + jogador_1 + " venceu!");
        }
        else if (soma % 2 == 0 && jogador1_escolher_impar_ou_par == true)
        {
            Debug.Log(soma + " é um número par, portanto " + jogador_2 + " venceu!");
        }
        else
        {
            Debug.Log(soma + " é um número ímpar, portanto " + jogador_2 + " venceu!");
        }
    }
    
    /* 
        void Start()
    {
        int soma = mao_jogador_1 + mao_jogador_2;

        if (soma % 2 == 0 && jogador1_escolher_impar_ou_par == false)
        {
            Debug.Log(soma + " é um número par, portanto " + jogador_1 + " venceu!");

        }
        else if (soma % 2 == 1 && jogador1_escolher_impar_ou_par == true)
        {
            Debug.Log(soma + " é um número ímpar, portanto " + jogador_1 + " venceu!");
        }
        else if (soma % 2 == 0 && jogador1_escolher_impar_ou_par == true)
        {
            Debug.Log(soma + " é um número par, portanto " + jogador_2 + " venceu!");
        }
        else
        {
            Debug.Log(soma + " é um número ímpar, portanto " + jogador_2 + " venceu!");
        }

    }*/
}
