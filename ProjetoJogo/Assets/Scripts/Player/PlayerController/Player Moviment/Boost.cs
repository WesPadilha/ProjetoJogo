using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boost : MonoBehaviour
{
    public List<Collider> collidersToDisable = new List<Collider>();
    private bool isBoosting = false;
    private float boostTimer = 0.0f;
    public float boostDuration = 0.5f;

    // Reference to the StaminaPlayer script
    public StaminaPlayer staminaPlayer;

    void Start()
    {
        // Find the StaminaPlayer script in the scene
        staminaPlayer = FindObjectOfType<StaminaPlayer>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Space))
        {
            // Inicia o impulso
            isBoosting = true;
            boostTimer = 0.0f;

            // Desativa os colliders escolhidos
            SetCollidersEnabled(false);

            // Perde 30 de stamina
            staminaPlayer.DecreaseStamina(30.0f);
        }

        if (isBoosting)
        {
            boostTimer += Time.deltaTime;

            // Lógica do impulso

            if (boostTimer >= boostDuration)
            {
                // Termina o impulso
                isBoosting = false;

                // Ativa os colliders novamente
                SetCollidersEnabled(true);
            }
        }
    }

    void SetCollidersEnabled(bool isEnabled)
    {
        foreach (Collider collider in collidersToDisable)
        {
            if (collider != null)
            {
                collider.enabled = isEnabled;
            }
        }
    }
}
