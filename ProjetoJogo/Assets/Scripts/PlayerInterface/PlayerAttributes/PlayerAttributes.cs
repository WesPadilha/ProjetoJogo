using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [SerializeField] private int strength = 4;
    [SerializeField] private int dexterity = 4;
    [SerializeField] private int constitution = 4;
    [SerializeField] private int intelligence = 4;
    [SerializeField] private int wisdom = 4;
    [SerializeField] private int charisma = 4;

    private void Start()
    {
        // Set initial attribute values when the game starts
        SetInitialAttributes(strength, dexterity, constitution, intelligence, wisdom, charisma);
    }
    
    private void SetInitialAttributes(int initialStrength, int initialDexterity, int initialConstitution, int initialIntelligence, int initialWisdom, int initialCharisma)
    {
        // Implement logic to set initial attributes here
    }
    
    public void UpdateStrength(int value)
    {
        strength += value;
    }

    public void UpdateDexterity(int value)
    {
        dexterity += value;
    }

    public void UpdateConstitution(int value)
    {
        constitution += value;
    }

    public void UpdateIntelligence(int value)
    {
        intelligence += value;
    }

    public void UpdateWisdom(int value)
    {
        wisdom += value;
    }

    public void UpdateCharisma(int value)
    {
        charisma += value;
    }

    public (int, int, int, int, int, int) GetAttributes()
    {
        return (strength, dexterity, constitution, intelligence, wisdom, charisma);
    }
}