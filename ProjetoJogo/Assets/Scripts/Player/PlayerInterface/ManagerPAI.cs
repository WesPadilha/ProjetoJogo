using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerPAI : MonoBehaviour
{
    public AttributesBook attributesBook;
    public Canvas inventory;
    public PerkController perkController;
    public CameraController cameraController;

    public bool IsAnyUIActive()
    {
        // Logic to check if any UI elements are active
        return attributesBook.gameObject.activeSelf || inventory.gameObject.activeSelf || perkController.gameObject.activeSelf;
    }

    void Update()
    {
        bool isAnyUIOpen = attributesBook.gameObject.activeSelf || inventory.gameObject.activeSelf || perkController.gameObject.activeSelf;

        if (isAnyUIOpen)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            ToggleAttributesBook();
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            TogglePerkController();
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            ToggleInventory();
        }
    }

    void ToggleAttributesBook()
    {
        bool isActive = attributesBook.gameObject.activeSelf;
        attributesBook.gameObject.SetActive(!isActive);
        if (!isActive)
        {
            inventory.gameObject.SetActive(false);
            perkController.gameObject.SetActive(false);
            cameraController.SetMouseLock(!isActive);
        }
        else
        {
            cameraController.SetMouseLock(false); // Liberar mouse quando o livro de atributos estiver aberto
        }
    }

    void TogglePerkController()
    {
        bool isActive = perkController.gameObject.activeSelf;
        perkController.gameObject.SetActive(!isActive);
        if (!isActive)
        {
            attributesBook.gameObject.SetActive(false);
            inventory.gameObject.SetActive(false);
            cameraController.SetMouseLock(!isActive);
        }
        else
        {
            cameraController.SetMouseLock(false); // Liberar mouse quando o controlador de perks estiver aberto
        }
    }

    void ToggleInventory()
    {
        bool isActive = inventory.gameObject.activeSelf;
        inventory.gameObject.SetActive(!isActive);
        if (!isActive)
        {
            perkController.gameObject.SetActive(false);
            attributesBook.gameObject.SetActive(false);
            cameraController.SetMouseLock(!isActive);
        }
        else
        {
            cameraController.SetMouseLock(false); // Liberar mouse quando o inventário estiver aberto
        }
    }
}
