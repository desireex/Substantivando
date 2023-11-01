using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class responder : MonoBehaviour
{
    public int idTema;
    public TMP_Text pergunta;
    public TMP_Text respostaA;
    public TMP_Text respostaB;
    public TMP_Text respostaC;
    public TMP_Text respostaD;

    public string[] perguntas;
    public string[] alternativaA;
    public string[] alternativaB;
    public string[] alternativaC;
    public string[] alternativaD;
    public string[] corretas; //armazenamento de respostas certas
    private int idPergunta;
    private int acertos;
    private int questoes;
    void Start()
    {
        idPergunta = 0;
        questoes = perguntas.Length;
        pergunta.text = perguntas[idPergunta];
        respostaA.text = alternativaA[idPergunta];
        respostaB.text = alternativaB[idPergunta];
        respostaC.text = alternativaC[idPergunta];
        respostaD.text = alternativaD[idPergunta];   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
public void resposta(string alternativa){
    Debug.Log(alternativa);
    switch (alternativa)
    {
        case "A":
            if(alternativaA[idPergunta] == corretas[idPergunta]){
                acertos += 1;
            }
        break;
        case "B":
            if(alternativaB[idPergunta] == corretas[idPergunta]){
                acertos += 1;
                Debug.Log("acerto");
            }
        break;
        case "C":
            if(alternativaC[idPergunta] == corretas[idPergunta]){
                acertos += 1;
            }
        break;
        case "D":
            if(alternativaD[idPergunta] == corretas[idPergunta]){
                acertos += 1;
            }
        break;
    }
}


}
