using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TarefaModulo2 : MonoBehaviour
{
    [SerializeField]
    float value1;
    [SerializeField]
    float value2;
    [SerializeField]
    float value3;

    // Start is called before the first frame update
    void Start()
    {
        float[] values = {value1, value2, value3};
        float higher = values[0];

        for (int i = 0; i < 3; i++)
        {
            if(i + 1 < 3)
            {
                if (values[i] > values[i + 1])
                {
                    higher = values[i];
                }
                else if (values[i] < values[i + 1])
                {
                    higher = values[i + 1];
                }
            }  
        }

        Debug.Log("Maior valor: " + higher);
        Debug.Log("Obrigado pela correção!");
    }
}
