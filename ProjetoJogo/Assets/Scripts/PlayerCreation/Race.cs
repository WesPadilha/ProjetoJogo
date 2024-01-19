using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
    public GameObject humanPrefab;
    public GameObject elfPrefab;
    public GameObject dwarfPrefab;
    public GameObject orcPrefab;

    public GameController gameController; // Adicione esta linha para declarar a variável gameController

    private GameObject selectedPrefab; // Prefab selecionado pelo jogador

    private void Start()
    {
        // Certifique-se de atribuir manualmente a referência ao GameController no Editor do Unity
        // ou encontre o GameController em tempo de execução usando GameObject.FindObjectOfType<GameController>()
        if (gameController == null)
        {
            Debug.LogError("GameController não atribuído ao script Race. Atribua-o no Editor do Unity ou encontre-o em tempo de execução.");
        }
    }

    public void SelectHuman()
    {
        selectedPrefab = humanPrefab;
        OnOptionSelected();
    }

    public void SelectElf()
    {
        selectedPrefab = elfPrefab;
        OnOptionSelected();
    }

    public void SelectDwarf()
    {
        selectedPrefab = dwarfPrefab;
        OnOptionSelected();
    }

    public void SelectOrc()
    {
        selectedPrefab = orcPrefab;
        OnOptionSelected();
    }

    public void SelectRace()
    {
        // Destruir personagem existente, se houver
        Destroy(GameObject.FindGameObjectWithTag("Player"));

        // Spawn do novo personagem
        Instantiate(selectedPrefab, Vector3.zero, Quaternion.identity);
    }

    private void OnOptionSelected()
    {
        // Verifica se GameController está atribuído antes de chamá-lo
        if (gameController != null)
        {
            // Chama a função OnOptionSelected no GameController
            gameController.OnOptionSelected();
        }
        else
        {
            Debug.LogError("GameController não encontrado. Certifique-se de atribuir o GameController ao script Race no Editor do Unity.");
        }
    }
}
