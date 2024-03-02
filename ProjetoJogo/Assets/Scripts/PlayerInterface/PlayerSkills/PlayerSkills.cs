using UnityEngine;

public class PlayerSkills : MonoBehaviour
{
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

    public (int, int, int, int, int, int, int, int, int, int) GetSkills()
    {
        return (greatWeapons, rangedWeapons, smallWeapons, conjuration, lockpicking,
                camouflage, defense, medicine, trade, oratory);
    }
}
