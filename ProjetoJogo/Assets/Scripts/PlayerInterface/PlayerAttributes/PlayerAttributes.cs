using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    public int strength;
    public int dexterity;
    public int constitution;
    public int intelligence;
    public int wisdom;
    public int charisma;

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