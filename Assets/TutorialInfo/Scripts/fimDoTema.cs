using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fimDoTema : MonoBehaviour
{
    private int acertos;
    public TMP_Text txtacertos;

    void Start()
    {

        acertos = PlayerPrefs.GetInt("acertosTemp");
        txtacertos.text = "Você acertou "+ acertos.ToString()+" de 5 perguntas!";
    }
}
