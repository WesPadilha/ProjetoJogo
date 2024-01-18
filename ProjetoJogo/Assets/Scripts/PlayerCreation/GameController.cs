using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject selectionScreen;

    // Este método será chamado quando o jogador escolher uma das quatro opções
    public void OnOptionSelected()
    {
        // Desativar a câmera principal
        mainCamera.gameObject.SetActive(false);

        // Desativar a tela de seleção
        selectionScreen.SetActive(false);
    }
}
