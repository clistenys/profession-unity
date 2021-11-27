using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class SeletorDeEnigma : MonoBehaviour
{
    [SerializeField] ListaDeEnigmas lista;

    [SerializeField] Text perguntaTexto;
    [SerializeField] Text botao1Texto;
    [SerializeField] Text botao2Texto;
    [SerializeField] Text botao3Texto;
    [SerializeField] Text botao4Texto;

    List<string> respostasPossiveis = new List<string>();

    int indexPergunta;
    void Start()
    {
        SetEnigma();
    }

    void SetEnigma()
    {
        indexPergunta = Random.Range(0, lista.listaDeEnigmas.Count);

        perguntaTexto.text = lista.listaDeEnigmas[indexPergunta].pergunta;
        respostasPossiveis.Add(lista.listaDeEnigmas[indexPergunta].respostaCorreta);
        respostasPossiveis.Add(lista.listaDeEnigmas[indexPergunta].respostaErrada1);
        respostasPossiveis.Add(lista.listaDeEnigmas[indexPergunta].respostaErrada2);
        respostasPossiveis.Add(lista.listaDeEnigmas[indexPergunta].respostaErrada3);

        int indexRespsota = Random.Range(0, respostasPossiveis.Count);

        botao1Texto.text = respostasPossiveis[indexRespsota];
        respostasPossiveis.Remove(respostasPossiveis[indexRespsota]);
        indexRespsota = Random.Range(0, respostasPossiveis.Count);

        botao2Texto.text = respostasPossiveis[indexRespsota];
        respostasPossiveis.Remove(respostasPossiveis[indexRespsota]);
        indexRespsota = Random.Range(0, respostasPossiveis.Count);

        botao3Texto.text = respostasPossiveis[indexRespsota];
        respostasPossiveis.Remove(respostasPossiveis[indexRespsota]);
        indexRespsota = Random.Range(0, respostasPossiveis.Count);

        botao4Texto.text = respostasPossiveis[indexRespsota];
        respostasPossiveis.Remove(respostasPossiveis[indexRespsota]);
        indexRespsota = Random.Range(0, respostasPossiveis.Count);
    }

    public void OnClick(Text TextoBotao)
    {
        if (TextoBotao.text == lista.listaDeEnigmas[indexPergunta].respostaCorreta)
        {
            lista.listaDeEnigmas.Remove(lista.listaDeEnigmas[indexPergunta]);
            SetEnigma();
        }
        else
        {
            Debug.Log("Resposta Errrada");
        }
    }
}
