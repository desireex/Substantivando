using UnityEngine;
using UnityEngine.UI;

public class DesativarInteratividadeFilhos : MonoBehaviour
{
    // Referência para o botão pai
    public Button botaoPai;

    void Start()
    {
        // Desativa a interatividade de todos os filhos do botão pai
        DesativarInteratividadeDosFilhos(botaoPai.transform);
    }

    void DesativarInteratividadeDosFilhos(Transform pai)
    {
        // Itera por todos os filhos do pai
        foreach (Transform filho in pai)
        {
            // Obtém o componente Button do filho, se existir
            Button botaoFilho = filho.GetComponent<Button>();

            // Se o componente Button existir, desativa a interatividade
            if (botaoFilho != null)
            {
                botaoFilho.interactable = false;
            }

            // Chama recursivamente a função para os filhos do filho atual
            DesativarInteratividadeDosFilhos(filho);
        }
    }
}
