using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class responder : MonoBehaviour
{
    public Button btnproximo;

    public GameObject acerto;
    public GameObject erro;
    public GameObject alegoriaDaPergunta;
    public GameObject alegoriaDoAcerto;
    public GameObject alegoriaDoErro;

    public TMP_Text txtLetraAresp;
    public TMP_Text txtLetraBresp;
    public TMP_Text txtLetraCresp;
    public TMP_Text txtLetraDresp;

    public Button btnLetraA;
    public Button btnLetraB;
    public Button btnLetraC;
    public Button btnLetraD;

    public int idTema;
    public TMP_Text pergunta;
    public TMP_Text respostaA;
    public TMP_Text respostaB;
    public TMP_Text respostaC;
    public TMP_Text respostaD;

    public GameObject[] alegoriaPergunta;
    public GameObject[] alegoriaAcerto;
    public GameObject[] alegoriaErro;

    public string[] txtLetraASelecionada;
    public string[] txtLetraBSelecionada;
    public string[] txtLetraCSelecionada;
    public string[] txtLetraDSelecionada;

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
        
        txtLetraAresp.text = null;
        txtLetraBresp.text = null;
        txtLetraCresp.text = null;
        txtLetraDresp.text = null;

        alegoriaDaPergunta = alegoriaPergunta[idPergunta];
        alegoriaDoAcerto = alegoriaAcerto[idPergunta];
        alegoriaDoErro = alegoriaErro[idPergunta];
    }
    public void resposta(string alternativa){
        Debug.Log(alternativa);
        alegoriaDaPergunta.SetActive(false);
        switch (alternativa)
        {
            case "A":
                if(alternativaA[idPergunta] == corretas[idPergunta]){
                    acertos += 1;
                    acerto.transform.SetParent(btnLetraA.transform, false);
                    acerto.SetActive(true);
                    alegoriaDoAcerto.SetActive(true);
                    Debug.Log("acerto");
                }
                else
                {
                    erro.transform.SetParent(btnLetraA.transform, false);
                    erro.SetActive(true);
                    alegoriaDoErro.SetActive(true);
                }
                txtLetraAresp.text = txtLetraASelecionada[idPergunta];
                break;
            case "B":
                if(alternativaB[idPergunta] == corretas[idPergunta]){
                    acertos += 1;
                    acerto.transform.SetParent(btnLetraB.transform, false);
                    acerto.SetActive(true);
                    alegoriaDoAcerto.SetActive(true);
                    Debug.Log("acerto");
                }
                else
                {
                    erro.transform.SetParent(btnLetraB.transform, false);
                    erro.SetActive(true);
                    alegoriaDoErro.SetActive(true);
                }
                txtLetraBresp.text = txtLetraBSelecionada[idPergunta];
                break;
            case "C":
                if(alternativaC[idPergunta] == corretas[idPergunta]){
                    acertos += 1;
                    acerto.transform.SetParent(btnLetraC.transform, false);
                    acerto.SetActive(true);
                    alegoriaDoAcerto.SetActive(true);
                    Debug.Log("acerto");
                }
                else
                {
                    erro.transform.SetParent(btnLetraC.transform, false);
                    erro.SetActive(true);
                    alegoriaDoErro.SetActive(true);
                }
                txtLetraCresp.text = txtLetraCSelecionada[idPergunta];
                break;
            case "D":
                if(alternativaD[idPergunta] == corretas[idPergunta]){
                    acertos += 1;
                    acerto.transform.SetParent(btnLetraD.transform, false);
                    acerto.SetActive(true);
                    alegoriaDoAcerto.SetActive(true);
                    Debug.Log("acerto");
                }
                else
                {
                    erro.transform.SetParent(btnLetraD.transform, false);
                    erro.SetActive(true);
                    alegoriaDoErro.SetActive(true);
                }
                txtLetraDresp.text = txtLetraDSelecionada[idPergunta];
                break;
        }
    }
}
