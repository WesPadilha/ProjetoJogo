using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Race : MonoBehaviour
{
    public GameObject humanPrefab;
    public GameObject elfPrefab;
    public GameObject dwarfPrefab;
    public GameObject orcPrefab;

    public Attributes attributes;   
    public Skills skills;

    public GameController gameController;

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
        attributes.SetAttributesBasedOnRace("Human");
        OnOptionSelected();
    }
    public void SelectElf()
    {
        selectedPrefab = elfPrefab;
        attributes.SetAttributesBasedOnRace("Elf");
        OnOptionSelected();
    }
    public void SelectDwarf()
    {
        selectedPrefab = dwarfPrefab;
        attributes.SetAttributesBasedOnRace("Dwarf");
        OnOptionSelected();
    }
    public void SelectOrc()
    {
        selectedPrefab = orcPrefab;
        attributes.SetAttributesBasedOnRace("Orc");
        OnOptionSelected();
    }
    public void SelectRace()
    {
        // Destruir personagem existente, se houver
        GameObject existingPlayer = GameObject.FindGameObjectWithTag("Player");
        if (existingPlayer != null)
        {
            Destroy(existingPlayer);
        }

        // Spawn do novo personagem
        GameObject newPlayer = Instantiate(selectedPrefab, Vector3.zero, Quaternion.identity);

        // Obtém a referência ao componente PlayerAttributes do novo jogador
        PlayerAttributes playerAttributes = newPlayer.GetComponentInChildren<PlayerAttributes>();
        if (playerAttributes != null)
        {
            // Obtém os valores dos atributos do jogador
            int strength = attributes.strength;
            int dexterity = attributes.dexterity;
            int constitution = attributes.constitution;
            int intelligence = attributes.intelligence;
            int wisdom = attributes.wisdom;
            int charisma = attributes.charisma;

            // Configura os valores dos atributos no script PlayerAttributes
            playerAttributes.SetAttributes(strength, dexterity, constitution, intelligence, wisdom, charisma);
        }

        PlayerSkills playerSkills = newPlayer.GetComponentInChildren<PlayerSkills>();
        if (playerSkills != null)
        {
            // Obtém os valores das habilidades do jogador
            int greatWeapons = skills.greatWeapons;
            int rangedWeapons = skills.rangedWeapons;
            int smallWeapons = skills.smallWeapons;
            int conjuration = skills.conjuration;
            int lockpicking = skills.lockpicking;
            int camouflage = skills.camouflage;
            int defense = skills.defense;
            int medicine = skills.medicine;
            int trade = skills.trade;
            int oratory = skills.oratory;

            // Configura os valores das habilidades no script PlayerSkills
            playerSkills.greatWeapons = greatWeapons;
            playerSkills.rangedWeapons = rangedWeapons;
            playerSkills.smallWeapons = smallWeapons;
            playerSkills.conjuration = conjuration;
            playerSkills.lockpicking = lockpicking;
            playerSkills.camouflage = camouflage;
            playerSkills.defense = defense;
            playerSkills.medicine = medicine;
            playerSkills.trade = trade;
            playerSkills.oratory = oratory;
        }
        else
        {
            Debug.LogError("PlayerSkills não encontrado no jogador recém-criado.");
        }
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

    // Este método será chamado quando o jogador pressionar o botão "Voltar" na escolha de raça
    public void OnRaceBackButtonPressed()
    {
        // Verifica se GameController está atribuído antes de chamá-lo
        if (gameController != null)
        {
            // Chama a função OnRaceBackButtonPressed no GameController
            gameController.OnRaceBackButtonPressed();
        }
        else
        {
            Debug.LogError("GameController não encontrado. Certifique-se de atribuir o GameController ao script Race no Editor do Unity.");
        }
    }
}
