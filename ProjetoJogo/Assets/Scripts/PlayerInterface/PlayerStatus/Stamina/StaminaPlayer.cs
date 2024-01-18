using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaminaPlayer : MonoBehaviour
{
    public float maxStamina = 100.0f;
    public float minStamina = 0.0f;
    public float staminaDecreaseRate = 20.0f; // Stamina decrease rate when running
    public float staminaIncreaseRate = 10.0f; // Stamina increase rate when not running
    public float walkSpeed = 3.0f;
    public float runSpeed = 6.0f;

    private float currentStamina;
    private Player player; // Reference to the Player script
    public StaminaBar staminaBar; // Reference to the StaminaBar script

    void Start()
    {
        currentStamina = maxStamina;
        player = GetComponent<Player>();
        staminaBar = FindObjectOfType<StaminaBar>(); // Assuming StaminaBar is a singleton or only one instance in the scene
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            // Player is holding Shift to run
            if (currentStamina > minStamina)
            {
                currentStamina -= staminaDecreaseRate * Time.deltaTime;
                player.runSpeed = runSpeed; // Set the player's run speed directly
            }
            else
            {
                // Player has run out of stamina
                player.runSpeed = walkSpeed; // Set the player's speed to walkSpeed
            }
        }
        else
        {
            // Player is not holding Shift, regenerate stamina
            if (currentStamina < maxStamina)
            {
                currentStamina += staminaIncreaseRate * Time.deltaTime;
            }
            player.runSpeed = walkSpeed; // Set the player's speed to walkSpeed
        }

        // Clamp the stamina value within the specified range
        currentStamina = Mathf.Clamp(currentStamina, minStamina, maxStamina);

        // Update the stamina bar
        staminaBar.ModStamina(currentStamina / maxStamina);
    }
    public void DecreaseStamina(float amount)
    {
        currentStamina -= amount;
        currentStamina = Mathf.Clamp(currentStamina, minStamina, maxStamina);

        // Assuming StaminaBar is a component on the same GameObject as StaminaPlayer
        StaminaBar staminaBar = GetComponent<StaminaBar>();
        if (staminaBar != null)
        {
            staminaBar.ModStamina(currentStamina / maxStamina);
        }
    }
    public float GetCurrentStamina()
    {
        return currentStamina;
    }
}