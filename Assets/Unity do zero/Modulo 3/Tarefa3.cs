using System;
using UnityEngine;

public class Tarefa3 : MonoBehaviour
{
    int[] reaisDisponiveis = { 2, 5, 10, 20, 50, 100, 200 };
    int[] centavosDisponiveis = { 5, 10, 25, 50 };

    [SerializeField]
    float valorDesejado;

    // Start is called before the first frame update
    void Start()
    {
        int reais = (int)valorDesejado;
        ValorMaximoEmReais(reais, reaisDisponiveis.Length);


        float centavos = (valorDesejado - reais) * 100;
        ValorMaximoEmCentavos((int)centavos, centavosDisponiveis.Length);
    }

    string ValorMaximoEmReais(int valor, int contador)
    {
        string resposta = "";
        int qtdNotas = 0;

        if (valor >= 1)
        {
            contador--;
            qtdNotas = valor / reaisDisponiveis[contador];
            valor = valor % reaisDisponiveis[contador];
            
            Debug.Log("\n" + qtdNotas + " Cédula(s) de " + reaisDisponiveis[contador] + ValorMaximoEmReais(valor, contador));
        }

        return resposta;
    }

    string ValorMaximoEmCentavos(int valor, int contador)
    {
        string resposta = "";
        int qtdNotas = 0;

        if (valor >= 5)
        {
            contador--;
            qtdNotas = valor / centavosDisponiveis[contador];
            valor = valor % centavosDisponiveis[contador];

            Debug.Log("\n" + qtdNotas + " Moeda(s) de " + centavosDisponiveis[contador] + ValorMaximoEmCentavos(valor, contador));
        }

        return resposta;
    }
}
