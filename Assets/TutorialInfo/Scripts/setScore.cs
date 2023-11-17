using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class setScore : MonoBehaviour
{
    private int acertos = 0;
    public TMP_Text pontuacao;

    // Start is called before the first frame update
    private void Start()
    {
        for(int i = 1; i < 10; i++)
        {
            acertos += PlayerPrefs.GetInt("acertos" + i.ToString());
        }
        PlayerPrefs.SetInt("Score", acertos);
        pontuacao.text = PlayerPrefs.GetInt("Score").ToString();
    }
}
