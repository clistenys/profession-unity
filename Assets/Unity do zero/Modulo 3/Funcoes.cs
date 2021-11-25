using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funcoes : MonoBehaviour
{
    [SerializeField]
    float num;
    [SerializeField]
    float exp;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Exponencial((int)num, (int)exp));
    }

    int Exponencial(int numero, int expoente)
    {
        int resultado = numero;
        if(expoente > 1)
        {
            expoente--;
            resultado = Exponencial(numero, expoente) * numero;
        }

        return resultado;
    }
}
