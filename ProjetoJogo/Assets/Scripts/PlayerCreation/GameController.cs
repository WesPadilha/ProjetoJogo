using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject selectionScreen;
    public GameObject secondScreen;
    public GameObject thirdScreen;

    private void Start()
    {
        // Certifique-se de que os objetos estão desativados no início
        secondScreen.SetActive(false);
        thirdScreen.SetActive(false);
    }

    // Este método será chamado quando o jogador escolher uma das quatro opções
    public void OnOptionSelected()
    {
        // Desativar a tela de seleção
        selectionScreen.SetActive(false);

        // Ativar a segunda tela
        secondScreen.SetActive(true);
    }

    // Este método será chamado quando o jogador pressionar o botão "Próximo" na segunda tela
    public void OnNextButtonPressed()
    {
        // Desativar a segunda tela
        secondScreen.SetActive(false);

        // Ativar a terceira tela
        thirdScreen.SetActive(true);
    }

    // Este método será chamado quando o jogador pressionar o botão "Concluir" na terceira tela
    public void OnFinishButtonPressed()
    {
        // Desativar a terceira tela
        thirdScreen.SetActive(false);
        // Desativar a câmera principal
        mainCamera.gameObject.SetActive(false);

        // Spawn do prefab do personagem
        SpawnCharacter();
    }

    private void SpawnCharacter()
    {
        // Certifique-se de atribuir manualmente a referência ao Race no Editor do Unity
        // ou encontre o Race em tempo de execução usando GameObject.FindObjectOfType<Race>()
        Race raceScript = FindObjectOfType<Race>();
        if (raceScript != null)
        {
            // Chama a função SelectRace no Race
            raceScript.SelectRace();
        }
        else
        {
            Debug.LogError("Race não encontrado. Certifique-se de atribuir o Race ao script GameController no Editor do Unity.");
        }
    }
}

