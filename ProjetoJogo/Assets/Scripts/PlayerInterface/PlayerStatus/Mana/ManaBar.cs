using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{
    public Slider sliderMana;

    public void ModMana(float Mana)
    {
        sliderMana.value = Mana;
    }
}
