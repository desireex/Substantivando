using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuUI2 : MonoBehaviour
{
    public GameObject Explicacao;
    public GameObject Vamos;
    public GameObject Piscadela;

    public void ativar()
    {
        Explicacao.SetActive(false);
        Vamos.SetActive(true);
        Piscadela.SetActive(true);
    }
}
