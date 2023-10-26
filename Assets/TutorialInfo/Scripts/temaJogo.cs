using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class temaJogo : MonoBehaviour
{
    public Button btnFase;
    public Button btnPlay;
    public TMP_Text txtNomeDoTema;
    public string[] temaAtual;
    private int indexTema;

    void Start()
    {
        btnPlay.interactable = false;       
        indexTema = 0;
        txtNomeDoTema.text = temaAtual[indexTema];
    }

    public void selecioneTema(int i)
    {
        indexTema = i;
        txtNomeDoTema.text = temaAtual[indexTema];
        btnPlay.interactable = true;
    }

    public void Jogar(){
        SceneManager.LoadScene("Explica" + indexTema.ToString());
    }   

}
