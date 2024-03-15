using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExperienceBar : MonoBehaviour
{
    public Slider sliderExperience;

    public void ModExperience(float Experience)
    {
        sliderExperience.value = Experience;
    }
}
