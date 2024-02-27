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

    public Button increaseGreatWeaponsBtn;
    public Button decreaseGreatWeaponsBtn;
    public Button increaseRangedWeaponsBtn;
    public Button decreaseRangedWeaponsBtn;
    public Button increaseSmallWeaponsBtn;
    public Button decreaseSmallWeaponsBtn;
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

    private int availableSkillPoints =  20; // Inicialmente, você tem  20 pontos para distribuir nas habilidades

    private int greatWeapons;
    private int rangedWeapons;
    private int smallWeapons;
    private int lockpicking;
    private int camouflage;
    private int defense;
    private int medicine;
    private int trade;
    private int oratory;

    void Start()
    {
        // Inicialização dos botões e texto
        increaseGreatWeaponsBtn.onClick.AddListener(() => IncreaseSkill("GreatWeapons"));
        decreaseGreatWeaponsBtn.onClick.AddListener(() => DecreaseSkill("GreatWeapons"));
        increaseRangedWeaponsBtn.onClick.AddListener(() => IncreaseSkill("RangedWeapons"));
        decreaseRangedWeaponsBtn.onClick.AddListener(() => DecreaseSkill("RangedWeapons"));
        increaseSmallWeaponsBtn.onClick.AddListener(() => IncreaseSkill("SmallWeapons"));
        decreaseSmallWeaponsBtn.onClick.AddListener(() => DecreaseSkill("SmallWeapons"));
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
        SetInitialSkills(4,  4,  4,  4,  4,  4,  4,  4,  4);

        UpdateUI();
    }

    // Método para definir os valores iniciais das habilidades
    public void SetInitialSkills(int initialGreatWeapons, int initialRangedWeapons, int initialSmallWeapons, int initialLockpicking, int initialCamouflage, int initialDefense, int initialMedicine, int initialTrade, int initialOratory)
    {
        greatWeapons = initialGreatWeapons;
        rangedWeapons = initialRangedWeapons;
        smallWeapons = initialSmallWeapons;
        lockpicking = initialLockpicking;
        camouflage = initialCamouflage;
        defense = initialDefense;
        medicine = initialMedicine;
        trade = initialTrade;
        oratory = initialOratory;
    }

    void IncreaseSkill(string skill)
    {
        if (availableSkillPoints >  0)
        {
            switch (skill)
            {
                case "GreatWeapons":
                    greatWeapons += attributes.strength + attributes.dexterity;
                    break;
                case "RangedWeapons":
                    rangedWeapons += attributes.strength + attributes.dexterity;
                    break;
                case "SmallWeapons":
                    smallWeapons += attributes.strength + attributes.dexterity;
                    break;
                case "Lockpicking":
                    lockpicking += attributes.dexterity + attributes.wisdom;
                    break;
                case "Camouflage":
                    camouflage += attributes.dexterity + attributes.intelligence;
                    break;
                case "Defense":
                    defense += attributes.strength + attributes.constitution;
                    break;
                case "Medicine":
                    medicine += attributes.intelligence + attributes.wisdom;
                    break;
                case "Trade":
                    trade += attributes.wisdom + attributes.charisma;
                    break;
                case "Oratory":
                    oratory += attributes.wisdom + attributes.charisma;
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

    void UpdateUI()
    {
        greatWeaponsText.text = "Great Weapons: " + greatWeapons;
        rangedWeaponsText.text = "Ranged Weapons: " + rangedWeapons;
        smallWeaponsText.text = "Small Weapons: " + smallWeapons;
        lockpickingText.text = "Lockpicking: " + lockpicking;
        camouflageText.text = "Camouflage: " + camouflage;
        defenseText.text = "Defense: " + defense;
        medicineText.text = "Medicine: " + medicine;
        tradeText.text = "Trade: " + trade;
        oratoryText.text = "Oratory: " + oratory;

        availableSkillPointsText.text = "Skill Points: " + availableSkillPoints;
    }
}
