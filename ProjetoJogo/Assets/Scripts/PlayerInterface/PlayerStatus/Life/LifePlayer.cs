using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifePlayer : MonoBehaviour
{
    public LifeBar lifeBar;
    public float Life = 0f;

    public void TakeDamage(float damage)
    {
        Life -= damage;
        lifeBar.ModLife(Life);
    }
}
