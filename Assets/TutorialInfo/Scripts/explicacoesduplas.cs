using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using static UnityEditor.PlayerSettings;
public class explicacoesduplas : MonoBehaviour
{
    public GameObject[] PrimeiraExplicacao;
    public GameObject[] SegundaExplicacao;
    public string cenaPergunta;
    public string cenaTemas;
    public Button btnProximo;
    public Button btnVoltar;
    private int contaClicks;

    void Start()
    {
        contaClicks = 0;
        ativaPrimeiraExplicacao();
        desativaSegundaExplicacao();
        btnProximo.onClick = new Button.ButtonClickedEvent();
        btnProximo.onClick.AddListener(ControlaProximo);
        btnVoltar.onClick = new Button.ButtonClickedEvent();
        btnVoltar.onClick.AddListener(ControlaBotaoVoltar);
    }

    // Update is called once per frame
    void ativaPrimeiraExplicacao(){
        int tamanhoExplicacao1 = PrimeiraExplicacao.Length;
        for(int i = 0; i < tamanhoExplicacao1; i++){
            PrimeiraExplicacao[i].SetActive(true);
        }
    }
    void desativaPrimeiraExplicacao(){
        int tamanhoExplicacao1 = PrimeiraExplicacao.Length;
        for(int i = 0; i < tamanhoExplicacao1; i++){
            PrimeiraExplicacao[i].SetActive(false);
        }
    }
    void ativaSegundaExplicacao(){
        int tamanhoExplicacao2 = SegundaExplicacao.Length;
        for(int i = 0; i < tamanhoExplicacao2; i++){
            SegundaExplicacao[i].SetActive(true);
        }
    }
    void desativaSegundaExplicacao(){
        int tamanhoExplicacao2 = SegundaExplicacao.Length;
        for(int i = 0; i < tamanhoExplicacao2; i++){
            SegundaExplicacao[i].SetActive(false);
        }
    }

    void ControlaProximo()
    {
        if(contaClicks == 0)
        {
           desativaPrimeiraExplicacao();
           ativaSegundaExplicacao();
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
            ativaPrimeiraExplicacao();
            desativaSegundaExplicacao();
            contaClicks--;
        }
    }    
}
