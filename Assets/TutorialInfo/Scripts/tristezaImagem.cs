using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro;

public class tristezaImagem : MonoBehaviour
{
    public float LarguraTela, AlturaTela, Xposi��o, Yposi��o, ImLargura, ImAltura;
    public GameObject Imagem;
    // Start is called before the first frame update
    void Start()
    {
        LarguraTela = Screen.width; //mede a largura do aparelho de acordo com informa��es do sistema
        AlturaTela = Screen.height; //mede a altura do aparelho de acordo com informa��es do sistema
    }

    // Update is called once per frame
    void Update()
    {
        // ajusta a posi��o da imagem na tela com os parametros (X, Y, Z)
        // caso queira que o imagem fique no centro da tela, mantenha o valor da posi��o X como zero (0)
        Imagem.transform.position = new Vector3(Xposi��o, Yposi��o, 0);

        //Ajusta a largura e altura da imagem de acordo com o tamanho da tela
        // o valor e multiplicado pleo valor fornecido do sistema
        // Caso sej� atribuido o valor um (1) a variavel "ImAltura" a imagem tomara o tamanho da largura da tela
        // portanto, mantenha o valor entre zero (0) e um (1) na multiplica��o.
        Imagem.GetComponent<RectTransform>().sizeDelta = new Vector2((LarguraTela * ImLargura), (AlturaTela * ImAltura));

    }
}
