using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fimDoTema : MonoBehaviour
{
    private int numQuestoes;
    private int acertos;
    public TMP_Text txtacertos;
    private int idTema;

    void Start()
    {
        idTema = PlayerPrefs.GetInt("idTema");
        numQuestoes = PlayerPrefs.GetInt("numQuestoes" + idTema.ToString());
        acertos = PlayerPrefs.GetInt("acertosTemp");
        txtacertos.text = "Você acertou "+ acertos.ToString()+" de "+ numQuestoes.ToString()+" perguntas!";
    }
}
