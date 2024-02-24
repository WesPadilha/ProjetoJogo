using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attributes : MonoBehaviour
{
    public Text strengthText;
    public Text dexterityText;
    public Text constitutionText;
    public Text intelligenceText;
    public Text wisdomText;
    public Text charismaText;

    public Button increaseStrengthBtn;
    public Button decreaseStrengthBtn;
    public Button increaseDexterityBtn;
    public Button decreaseDexterityBtn;
    public Button increaseConstitutionBtn;
    public Button decreaseConstitutionBtn;
    public Button increaseIntelligenceBtn;
    public Button decreaseIntelligenceBtn;
    public Button increaseWisdomBtn;
    public Button decreaseWisdomBtn;
    public Button increaseCharismaBtn;
    public Button decreaseCharismaBtn;

    public Text availablePointsText;

    private int availablePoints = 5;

    private int strength;
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;

    void Start()
    {
        // Button and text initialization
        increaseStrengthBtn.onClick.AddListener(() => IncreaseAttribute("Strength"));
        decreaseStrengthBtn.onClick.AddListener(() => DecreaseAttribute("Strength"));
        increaseDexterityBtn.onClick.AddListener(() => IncreaseAttribute("Dexterity"));
        decreaseDexterityBtn.onClick.AddListener(() => DecreaseAttribute("Dexterity"));
        increaseConstitutionBtn.onClick.AddListener(() => IncreaseAttribute("Constitution"));
        decreaseConstitutionBtn.onClick.AddListener(() => DecreaseAttribute("Constitution"));
        increaseIntelligenceBtn.onClick.AddListener(() => IncreaseAttribute("Intelligence"));
        decreaseIntelligenceBtn.onClick.AddListener(() => DecreaseAttribute("Intelligence"));
        increaseWisdomBtn.onClick.AddListener(() => IncreaseAttribute("Wisdom"));
        decreaseWisdomBtn.onClick.AddListener(() => DecreaseAttribute("Wisdom"));
        increaseCharismaBtn.onClick.AddListener(() => IncreaseAttribute("Charisma"));
        decreaseCharismaBtn.onClick.AddListener(() => DecreaseAttribute("Charisma"));

        // Set initial attribute values
        SetInitialAttributes(4, 4, 4, 4, 4, 4);

        UpdateUI();
        
    }

    // Method to set initial attribute values
    public void SetInitialAttributes(int initialStrength, int initialDexterity, int initialConstitution, int initialIntelligence, int initialWisdom, int initialCharisma)
    {
        strength = initialStrength;
        dexterity = initialDexterity;
        constitution = initialConstitution;
        intelligence = initialIntelligence;
        wisdom = initialWisdom;
        charisma = initialCharisma;

        UpdateUI();
    }

    void IncreaseAttribute(string attribute)
    {
        if (availablePoints > 0)
        {
            switch (attribute)
            {
                case "Strength":
                    strength++;
                    break;
                case "Dexterity":
                    dexterity++;
                    break;
                case "Constitution":
                    constitution++;
                    break;
                case "Intelligence":
                    intelligence++;
                    break;
                case "Wisdom":
                    wisdom++;
                    break;
                case "Charisma":
                    charisma++;
                    break;
            }

            availablePoints--;
            UpdateUI();
        }
    }

    void DecreaseAttribute(string attribute)
    {
        switch (attribute)
        {
            case "Strength":
                if (strength > 0)
                {
                    strength--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
            case "Dexterity":
                if (dexterity > 0)
                {
                    dexterity--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
            case "Constitution":
                if (constitution > 0)
                {
                    constitution--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
            case "Intelligence":
                if (intelligence > 0)
                {
                    intelligence--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
            case "Wisdom":
                if (wisdom > 0)
                {
                    wisdom--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
            case "Charisma":
                if (charisma > 0)
                {
                    charisma--;
                    availablePoints++;
                    UpdateUI();
                }
                break;
        }
    }

    void UpdateUI()
    {
        strengthText.text = "Strength: " + strength;
        dexterityText.text = "Dexterity: " + dexterity;
        constitutionText.text = "Constitution: " + constitution;
        intelligenceText.text = "Intelligence: " + intelligence;
        wisdomText.text = "Wisdom: " + wisdom;
        charismaText.text = "Charisma: " + charisma;

        availablePointsText.text = "Available Points: " + availablePoints;
    }
}