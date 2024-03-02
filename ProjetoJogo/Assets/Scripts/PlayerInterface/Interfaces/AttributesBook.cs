using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AttributesBook : MonoBehaviour
{
    public PlayerAttributes attributes;
    public PlayerSkills skills;

    //Atributos
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

    //Texto para os atributos
    public Text strengthText;
    public Text dexterityText;
    public Text constitutionText;
    public Text intelligenceText;
    public Text wisdomText;
    public Text charismaText;

    //Skills
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

    //Texto  para as skills
    public Text greatWeaponsText;
    public Text rangedWeaponsText;
    public Text smallWeaponsText;
    public Text conjurationText;
    public Text lockpickingText;
    public Text camouflageText;
    public Text defenseText;
    public Text medicineText;
    public Text tradeText;
    public Text oratoryText;

    //Botãos para skills
    //public Button increaseGreatWeaponsBtn;
    //public Button increaseRangedWeaponsBtn;
    //public Button increaseSmallWeaponsBtn;
    //public Button increaseConjurationBtn; 
    //public Button increaseLockpickingBtn;
    //public Button increaseCamouflageBtn;
    //public Button increaseDefenseBtn;
    //public Button increaseMedicineBtn;
    //public Button increaseTradeBtn;
    //public Button increaseOratoryBtn;
    void Start()
    {
        //increaseGreatWeaponsBtn.onClick.AddListener(() => IncreaseSkill("GreatWeapons"));
        //increaseRangedWeaponsBtn.onClick.AddListener(() => IncreaseSkill("RangedWeapons"));
        //increaseSmallWeaponsBtn.onClick.AddListener(() => IncreaseSkill("SmallWeapons"));
        //increaseConjurationBtn.onClick.AddListener(() => IncreaseSkill("Conjuration"));
        //increaseLockpickingBtn.onClick.AddListener(() => IncreaseSkill("Lockpicking"));
        //increaseCamouflageBtn.onClick.AddListener(() => IncreaseSkill("Camouflage"));
        //increaseDefenseBtn.onClick.AddListener(() => IncreaseSkill("Defense"));
        //increaseMedicineBtn.onClick.AddListener(() => IncreaseSkill("Medicine"));
        //increaseTradeBtn.onClick.AddListener(() => IncreaseSkill("Trade"));
        //increaseOratoryBtn.onClick.AddListener(() => IncreaseSkill("Oratory"));

        gameObject.SetActive(false);

        UpdateUI();
    }

    // Update is called once per frame
    void UpdateUI()
    {
        // Get attribute values from PlayerAttributes component
        (int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma) = attributes.GetAttributes();

        // Update attribute texts
        strengthText.text = "Strength: " + strength;
        dexterityText.text = "Dexterity: " + dexterity;
        constitutionText.text = "Constitution: " + constitution;
        intelligenceText.text = "Intelligence: " + intelligence;
        wisdomText.text = "Wisdom: " + wisdom;
        charismaText.text = "Charisma: " + charisma;

        // Get skill values from PlayerSkills component
        (int greatWeapons, int rangedWeapons, int smallWeapons, int conjuration, int lockpicking,
         int camouflage, int defense, int medicine, int trade, int oratory) = skills.GetSkills();

        // Update skill texts
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
    }
    
}
