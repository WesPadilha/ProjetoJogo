using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StaminaBar : MonoBehaviour
{
    public Slider sliderStamina;

    public void ModStamina(float stamina)
    {
        sliderStamina.value = stamina;
    }
}
