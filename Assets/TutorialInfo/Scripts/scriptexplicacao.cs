using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;

public class scriptexplicacao : MonoBehaviour
{
    public Button btnProximo;
    public Button btnVoltar;
    private int contaClicks;
    public GameObject Explicacao;
    public GameObject Piscadela;
    public GameObject Vamos;
    public string cenaPergunta;
    public string cenaTemas;
    void Start()
    {
        contaClicks = 0;
        Explicacao.SetActive(true);
        Vamos.SetActive(false);
        Piscadela.SetActive(false);
        btnProximo.onClick = new Button.ButtonClickedEvent();
        btnProximo.onClick.AddListener(ControlaBotaoProx);
        btnVoltar.onClick = new Button.ButtonClickedEvent();
        btnVoltar.onClick.AddListener(ControlaBotaoVoltar);
    }

    void ControlaBotaoProx()
    {
        if (contaClicks == 0) {
            Explicacao.SetActive(false);
            Vamos.SetActive(true);
            Piscadela.SetActive(true);
            contaClicks++;
        }
        else if(contaClicks == 1)
        {
            SceneManager.LoadScene(cenaPergunta);
        }
    }

    void ControlaBotaoVoltar()
    {
        if(contaClicks == 0)
        {
            SceneManager.LoadScene(cenaTemas);
        }
        else if (contaClicks == 1)
        {
            Explicacao.SetActive(true);
            Vamos.SetActive(false);
            Piscadela.SetActive(false);
            contaClicks--;
        }
    }
}
