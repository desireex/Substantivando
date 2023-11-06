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
    public GameObject[] telasDoJogo;
    public string cenaPergunta;
    public string cenaTemas;
    private int numeroDeTelas;
    void Start()
    {
        contaClicks = 0;
        numeroDeTelas = telasDoJogo.Length;
        AtivaObjetos();
        DesativaObjetos(0);
        btnProximo.onClick = new Button.ButtonClickedEvent();
        btnProximo.onClick.AddListener(ControlaBotaoProx);
        btnVoltar.onClick = new Button.ButtonClickedEvent();
        btnVoltar.onClick.AddListener(ControlaBotaoVoltar);
    }

    void AtivaObjetos()
    {
        telasDoJogo[contaClicks].SetActive(true);
    }

    void DesativaObjetos(int botaopressionado)
    {
        if (botaopressionado == 0)
        {
            for(int i = 1; i < numeroDeTelas; i++)
            {
                telasDoJogo[i].SetActive(false);
            }
        }
        else
        {
            telasDoJogo[contaClicks + botaopressionado].SetActive(false);
        }
    }
    void ControlaBotaoProx()
    {
        if (contaClicks < numeroDeTelas) {
            contaClicks++;
            AtivaObjetos();
            DesativaObjetos(-1);
        }
        else
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
        else
        {
            contaClicks--;
            AtivaObjetos();
            DesativaObjetos(1);
        }
    }
}
