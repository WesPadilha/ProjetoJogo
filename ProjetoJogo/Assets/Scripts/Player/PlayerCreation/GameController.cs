using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject selectionScreen;
    public GameObject secondScreen;
    public Text messageText; 

    public Attributes attributes;
    public Skills skills;
    public ClassOption classOption;

    private void Start()
    {
        // Certifique-se de que os objetos estão desativados no início
        secondScreen.SetActive(false);
        messageText.gameObject.SetActive(false); // Novo
    }

    // Este método será chamado quando o jogador escolher uma das quatro opções
    public void OnOptionSelected()
    {
        // Desativar a tela de seleção
        selectionScreen.SetActive(false);

        // Ativar a segunda tela
        secondScreen.SetActive(true);

        // Esconder a mensagem de aviso
        messageText.gameObject.SetActive(false); // Novo
    }

    // Este método será chamado quando o jogador pressionar o botão "Concluir" na terceira tela
    public void OnFinishButtonPressed()
    {
        // Verificar se há pontos não distribuídos em atributos, habilidades ou falta de seleção de classe
        if (attributes.GetAvailablePoints() > 0 || skills.GetAvailableSkillPoints() > 0 || !classOption.ClassSelected())
        {
            // Mostrar mensagem de aviso
            messageText.text = "Distribua todos os pontos em Atributos, Habilidades e selecione uma Classe!";
            messageText.gameObject.SetActive(true);
            return;
        }

        // Desativar a terceira tela
        secondScreen.SetActive(false);
        // Desativar a câmera principal
        mainCamera.gameObject.SetActive(false);

        // Spawn do prefab do personagem
        SpawnCharacter();
    }

    // Este método será chamado quando o jogador pressionar o botão "Voltar" na escolha de raça
    public void OnRaceBackButtonPressed()
    {
        // Ativar a tela de seleção
        selectionScreen.SetActive(true);

        // Desativar a segunda e terceira telas
        secondScreen.SetActive(false);

        attributes.ResetAttributePoints();
        skills.ResetSkillPoints();

        classOption.EnableAllButtons();
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
