using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class tristezaImagem : MonoBehaviour
{
    public float LarguraTela, AlturaTela, Xposição, Yposição, ImLargura, ImAltura;
    public GameObject Imagem;
    // Start is called before the first frame update
    void Start()
    {
        LarguraTela = Screen.width; //mede a largura do aparelho de acordo com informações do sistema
        AlturaTela = Screen.height; //mede a altura do aparelho de acordo com informações do sistema
    }

    // Update is called once per frame
    void Update()
    {
        // ajusta a posição da imagem na tela com os parametros (X, Y, Z)
        // caso queira que o imagem fique no centro da tela, mantenha o valor da posição X como zero (0)
        Imagem.transform.position = new Vector3(Xposição, Yposição, 0);

        //Ajusta a largura e altura da imagem de acordo com o tamanho da tela
        // o valor e multiplicado pleo valor fornecido do sistema
        // Caso sejá atribuido o valor um (1) a variavel "ImAltura" a imagem tomara o tamanho da largura da tela
        // portanto, mantenha o valor entre zero (0) e um (1) na multiplicação.
        Imagem.GetComponent<RectTransform>().sizeDelta = new Vector2((LarguraTela * ImLargura), (AlturaTela * ImAltura));

    }
}
