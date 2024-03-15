using UnityEngine;

public class PlayerPerk : MonoBehaviour
{
    public PerkController perkController;
    public static bool isPerkActive = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            isPerkActive = !isPerkActive;
            perkController.gameObject.SetActive(isPerkActive);
            
        }
    }
}
