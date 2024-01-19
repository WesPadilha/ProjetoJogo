using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    public Slider sliderLife;

    public void ModLife(float Life)
    {
        sliderLife.value = Life;
    }
}
