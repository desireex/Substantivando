using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fimDoTema : MonoBehaviour
{
    private int numQuestoes;
    private int acertos;
    public TMP_Text txtacertos;

    void Start()
    {
        numQuestoes = PlayerPrefs.GetInt("numQuestoes");
        acertos = PlayerPrefs.GetInt("acertosTemp");
        txtacertos.text = "Você acertou "+ acertos.ToString()+" de "+ numQuestoes.ToString()+" perguntas!";
    }
}
