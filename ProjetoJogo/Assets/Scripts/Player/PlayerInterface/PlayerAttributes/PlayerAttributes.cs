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

    // Método para definir os atributos do jogador
    public void SetAttributes(int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
        // Define os atributos do jogador com os valores fornecidos
        this.strength = strength;
        this.dexterity = dexterity;
        this.constitution = constitution;
        this.intelligence = intelligence;
        this.wisdom = wisdom;
        this.charisma = charisma;
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