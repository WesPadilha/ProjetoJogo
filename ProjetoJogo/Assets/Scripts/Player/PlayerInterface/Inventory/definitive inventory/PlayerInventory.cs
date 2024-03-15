using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Canvas inventory;
    public CameraController cameraController;

    public bool inventoryActive = false;

    void Update()
    {
        // Toggle inventory visibility and mouse lock
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            inventoryActive = !inventoryActive;
            inventory.gameObject.SetActive(inventoryActive);
            cameraController.SetMouseLock(!inventoryActive); // Seta o estado de bloqueio do mouse na câmera
        }
    }
}
