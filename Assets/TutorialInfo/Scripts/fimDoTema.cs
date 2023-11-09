using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class fimDoTema : MonoBehaviour
{
    private int acertos;
    public TMP_Text txtacertos;

    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    void Start()
    {
        estrela1.SetActive(false);
        estrela2.SetActive(false);
        estrela3.SetActive(false);

        acertos = PlayerPrefs.GetInt("acertosTemp");
        txtacertos.text = "Você acertou "+ acertos.ToString()+" de 5 perguntas!";

        if(acertos == 5)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
            estrela3.SetActive(true);
        }
        else if (acertos >= 3)
        {
            estrela1.SetActive(true);
            estrela2.SetActive(true);
        }
        else if(acertos == 2)
        {
            estrela1.SetActive(true);
        }
    }
}
