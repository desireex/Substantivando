using UnityEngine;
using UnityEngine.SceneManagement;

public class contador : MonoBehaviour
{
  private float tempo;
  public string nomeDaCena;  
    // Start é chamado antes do primeiro quadro atualizar
    public void Mudatela(string cena)
    {
        SceneManager.LoadScene(cena);
    }

    // Update é chamado a cada quadro
    void Update()
    {
        tempo += Time.deltaTime;
        if (tempo >= 3)
        {
            Mudatela(nomeDaCena);
        }
    }
}
//corountine