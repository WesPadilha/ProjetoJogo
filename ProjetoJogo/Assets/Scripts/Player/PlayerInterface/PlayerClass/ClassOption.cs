using UnityEngine;
using UnityEngine.UI;

public class ClassOption : MonoBehaviour
{
    public Attributes attributes;
    public Button mageButton;
    public Button rogueButton;
    public Button rangerButton;
    public Button warriorButton;
    public Skills skills; // Reference to the Skills script

    private bool mageSelected = false;
    private bool rogueSelected = false;
    private bool rangerSelected = false;
    private bool warriorSelected = false;

    public void EnableAllButtons()
    {
        mageButton.interactable = true;
        rogueButton.interactable = true;
        rangerButton.interactable = true;
        warriorButton.interactable = true;

        mageSelected = false;
        rogueSelected = false;
        rangerSelected = false;
        warriorSelected = false;
    }

    public bool ClassSelected()
    {
        return mageSelected || rogueSelected || rangerSelected || warriorSelected;
    }

    private void Start()
    {
        mageButton.onClick.AddListener(ChooseMage);
        rogueButton.onClick.AddListener(ChooseRogue);
        rangerButton.onClick.AddListener(ChooseRanger);
        warriorButton.onClick.AddListener(ChooseWarrior);
    }

    private void ChooseMage()
    {
        if (!mageSelected)
        {
            RemovePreviousClassPoints();
            AddClassPoints(0, 0, 0, 1, 1, 0);
            mageSelected = true;
            rogueSelected = false;
            rangerSelected = false;
            warriorSelected = false;
            // Call ResetSkillPoints() when choosing a new class
            skills.ResetSkillPoints();
        }
    }

    private void ChooseRogue()
    {
        if (!rogueSelected)
        {
            RemovePreviousClassPoints();
            AddClassPoints(0, 1, 0, 0, 0, 1);
            mageSelected = false;
            rogueSelected = true;
            rangerSelected = false;
            warriorSelected = false;
            // Call ResetSkillPoints() when choosing a new class
            skills.ResetSkillPoints();
        }
    }

    private void ChooseRanger()
    {
        if (!rangerSelected)
        {
            RemovePreviousClassPoints();
            AddClassPoints(0, 1, 0, 1, 0, 0);
            mageSelected = false;
            rogueSelected = false;
            rangerSelected = true;
            warriorSelected = false;
            // Call ResetSkillPoints() when choosing a new class
            skills.ResetSkillPoints();
        }
    }

    private void ChooseWarrior()
    {
        if (!warriorSelected)
        {
            RemovePreviousClassPoints();
            AddClassPoints(1, 0, 1, 0, 0, 0);
            mageSelected = false;
            rogueSelected = false;
            rangerSelected = false;
            warriorSelected = true;
            // Call ResetSkillPoints() when choosing a new class
            skills.ResetSkillPoints();
        }
    }

    private void AddClassPoints(int str, int dex, int con, int intel, int wis, int cha)
    {
        attributes.strength += str;
        attributes.dexterity += dex;
        attributes.constitution += con;
        attributes.intelligence += intel;
        attributes.wisdom += wis;
        attributes.charisma += cha;

        attributes.UpdateUI();
    }

    private void RemovePreviousClassPoints()
    {
        if (mageSelected)
        {
            AddClassPoints(0, 0, 0, -1, -1, 0);
            mageSelected = false;
        }
        else if (rogueSelected)
        {
            AddClassPoints(0, -1, 0, 0, 0, -1);
            rogueSelected = false;
        }
        else if (rangerSelected)
        {
            AddClassPoints(0, -1, 0, -1, 0, 0);
            rangerSelected = false;
        }
        else if (warriorSelected)
        {
            AddClassPoints(-1, 0, -1, 0, 0, 0);
            warriorSelected = false;
        }
    }
}
