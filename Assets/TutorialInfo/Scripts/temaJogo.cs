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
    public TMP_Text txtAcertos;
    public string[] temaAtual;
    private int indexTema;

    void Start()
    {
        btnPlay.interactable = false;       
        indexTema = 0;
        txtNomeDoTema.text = temaAtual[indexTema];
        txtAcertos.gameObject.SetActive(false);
    }

    public void selecioneTema(int i)
    {
        indexTema = i;
        PlayerPrefs.SetInt("idTema", indexTema);
        txtAcertos.gameObject.SetActive(true);
        txtAcertos.text = "acertos: " + PlayerPrefs.GetInt("acertos" + i.ToString()).ToString() + "    respondidas: " 
            + PlayerPrefs.GetInt("numQuestoes" + indexTema.ToString()).ToString();
        txtNomeDoTema.text = temaAtual[indexTema];
        btnPlay.interactable = true;
    }

    public void Jogar(){
        SceneManager.LoadScene("Explica" + indexTema.ToString());
    }   

}
