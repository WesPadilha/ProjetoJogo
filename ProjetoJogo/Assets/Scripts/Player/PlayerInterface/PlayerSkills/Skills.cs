using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skills : MonoBehaviour
{
    public Attributes attributes;
    public Text greatWeaponsText;
    public Text rangedWeaponsText;
    public Text smallWeaponsText;
    public Text lockpickingText;
    public Text camouflageText;
    public Text defenseText;
    public Text medicineText;
    public Text tradeText;
    public Text oratoryText;
    public Text conjurationText;

    public Button increaseGreatWeaponsBtn;
    public Button decreaseGreatWeaponsBtn;
    public Button increaseRangedWeaponsBtn;
    public Button decreaseRangedWeaponsBtn;
    public Button increaseSmallWeaponsBtn;
    public Button decreaseSmallWeaponsBtn;
    public Button increaseConjurationBtn; 
    public Button decreaseConjurationBtn; 
    public Button increaseLockpickingBtn;
    public Button decreaseLockpickingBtn;
    public Button increaseCamouflageBtn;
    public Button decreaseCamouflageBtn;
    public Button increaseDefenseBtn;
    public Button decreaseDefenseBtn;
    public Button increaseMedicineBtn;
    public Button decreaseMedicineBtn;
    public Button increaseTradeBtn;
    public Button decreaseTradeBtn;
    public Button increaseOratoryBtn;
    public Button decreaseOratoryBtn;

    public Text availableSkillPointsText;

    private int availableSkillPoints = 20;

    public int greatWeapons;
    public int rangedWeapons;
    public int smallWeapons;
    public int conjuration;
    public int lockpicking;
    public int camouflage;
    public int defense;
    public int medicine;
    public int trade;
    public int oratory;

    void Start()
    {
        // Inicialização dos botões e texto
        increaseGreatWeaponsBtn.onClick.AddListener(() => IncreaseSkill("GreatWeapons"));
        decreaseGreatWeaponsBtn.onClick.AddListener(() => DecreaseSkill("GreatWeapons"));
        increaseRangedWeaponsBtn.onClick.AddListener(() => IncreaseSkill("RangedWeapons"));
        decreaseRangedWeaponsBtn.onClick.AddListener(() => DecreaseSkill("RangedWeapons"));
        increaseSmallWeaponsBtn.onClick.AddListener(() => IncreaseSkill("SmallWeapons"));
        decreaseSmallWeaponsBtn.onClick.AddListener(() => DecreaseSkill("SmallWeapons"));
        increaseConjurationBtn.onClick.AddListener(() => IncreaseSkill("Conjuration"));
        decreaseConjurationBtn.onClick.AddListener(() => DecreaseSkill("Conjuration"));
        increaseLockpickingBtn.onClick.AddListener(() => IncreaseSkill("Lockpicking"));
        decreaseLockpickingBtn.onClick.AddListener(() => DecreaseSkill("Lockpicking"));
        increaseCamouflageBtn.onClick.AddListener(() => IncreaseSkill("Camouflage"));
        decreaseCamouflageBtn.onClick.AddListener(() => DecreaseSkill("Camouflage"));
        increaseDefenseBtn.onClick.AddListener(() => IncreaseSkill("Defense"));
        decreaseDefenseBtn.onClick.AddListener(() => DecreaseSkill("Defense"));
        increaseMedicineBtn.onClick.AddListener(() => IncreaseSkill("Medicine"));
        decreaseMedicineBtn.onClick.AddListener(() => DecreaseSkill("Medicine"));
        increaseTradeBtn.onClick.AddListener(() => IncreaseSkill("Trade"));
        decreaseTradeBtn.onClick.AddListener(() => DecreaseSkill("Trade"));
        increaseOratoryBtn.onClick.AddListener(() => IncreaseSkill("Oratory"));
        decreaseOratoryBtn.onClick.AddListener(() => DecreaseSkill("Oratory"));

        // Definição dos valores iniciais das habilidades
        UpdateSkillsBasedOnAttributes();
    }

    // Método para definir os valores iniciais das habilidades
    public void UpdateSkillsBasedOnAttributes()
    {
        // Atualize cada habilidade com base nos atributos correspondentes
        greatWeapons = attributes.strength + attributes.dexterity;
        rangedWeapons = attributes.intelligence + attributes.dexterity;
        smallWeapons = attributes.strength + attributes.dexterity;
        conjuration = attributes.intelligence + attributes.charisma;
        lockpicking = attributes.dexterity + attributes.wisdom;
        camouflage = attributes.dexterity + attributes.intelligence;
        defense = attributes.strength + attributes.constitution;
        medicine = attributes.intelligence + attributes.wisdom;
        trade = attributes.wisdom + attributes.charisma;
        oratory = attributes.wisdom + attributes.charisma;

        // Atualize a UI
        UpdateUI();
    }
    void IncreaseSkill(string skill)
    {
        if (availableSkillPoints >  0)
        {
            switch (skill)
            {
                case "GreatWeapons":
                    greatWeapons ++;
                    break;
                case "RangedWeapons":
                    rangedWeapons ++;
                    break;
                case "SmallWeapons":
                    smallWeapons ++;
                    break;
                case "Conjuration":
                    conjuration ++;
                    break;
                case "Lockpicking":
                    lockpicking ++;
                    break;
                case "Camouflage":
                    camouflage ++;
                    break;
                case "Defense":
                    defense ++;
                    break;
                case "Medicine":
                    medicine ++;
                    break;
                case "Trade":
                    trade ++;
                    break;
                case "Oratory":
                    oratory ++;
                    break;
            }

            availableSkillPoints--;
            UpdateUI();
        }
    }

    void DecreaseSkill(string skill)
    {
        switch (skill)
        {
            case "GreatWeapons":
                if (greatWeapons >  0)
                {
                    greatWeapons--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "RangedWeapons":
                if (rangedWeapons >  0)
                {
                    rangedWeapons--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "SmallWeapons":
                if (smallWeapons >  0)
                {
                    smallWeapons--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Conjuration":
                if (conjuration > 0)
                {
                    conjuration--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Lockpicking":
                if (lockpicking >  0)
                {
                    lockpicking--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Camouflage":
                if (camouflage >  0)
                {
                    camouflage--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Defense":
                if (defense >  0)
                {
                    defense--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Medicine":
                if (medicine >  0)
                {
                    medicine--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Trade":
                if (trade >  0)
                {
                    trade--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
            case "Oratory":
                if (oratory >  0)
                {
                    oratory--;
                    availableSkillPoints++;
                    UpdateUI();
                }
                break;
        }
    }

    public void ResetSkillPoints()
    {
        availableSkillPoints = 20;
        UpdateSkillsBasedOnAttributes(); 
    }

    public int GetAvailableSkillPoints()
    {
        return availableSkillPoints;
    }

    void UpdateUI()
    {
        greatWeaponsText.text = "Great Weapons: " + greatWeapons;
        rangedWeaponsText.text = "Ranged Weapons: " + rangedWeapons;
        smallWeaponsText.text = "Small Weapons: " + smallWeapons;
        conjurationText.text = "Conjuration: " + conjuration;
        lockpickingText.text = "Lockpicking: " + lockpicking;
        camouflageText.text = "Camouflage: " + camouflage;
        defenseText.text = "Defense: " + defense;
        medicineText.text = "Medicine: " + medicine;
        tradeText.text = "Trade: " + trade;
        oratoryText.text = "Oratory: " + oratory;

        availableSkillPointsText.text = "Skill Points: " + availableSkillPoints;
    }
}
