using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MainMenuUI : MonoBehaviour{
    public void Play()
    {
        Debug.Log("Play");
    }
    public void DontPLay(){
        Debug.Log("A imagem não atrabalha");
    }
    public void MudaTela(string nomecena){
        SceneManager.LoadScene(nomecena);
    }
}
//
