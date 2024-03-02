using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBook : MonoBehaviour
{
    public AttributesBook attributesBook;
    public CameraController cameraController; // Adiciona referência à câmera

    bool attributesBookActive = false;

    public bool IsBookOpen()
    {
        return attributesBookActive;
    }

    // Update is called once per frame
    void Update()
    {
        // Verifica se a tecla "O" foi pressionada
        if (Input.GetKeyDown(KeyCode.O))
        {
            // Inverte o estado da tela do AttributesBook
            attributesBookActive = !attributesBookActive;

            // Ativa ou desativa o AttributesBook conforme necessário
            attributesBook.gameObject.SetActive(attributesBookActive);

            // Notifica a câmera sobre o estado do livro
            cameraController.SetMouseLock(!attributesBookActive);
        }
    }
}
