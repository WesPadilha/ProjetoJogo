using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public float rotationSpeed = 2.0f;
    public Vector3 offset = new Vector3(0, 0, 0);
    private bool isClimbing = false;
    private bool isMouseLocked = true; // Adicionado para controlar se o mouse está preso

    void LateUpdate()
    {
        if (!isClimbing && isMouseLocked) // Apenas controla a rotação quando o mouse está preso
        {
            HandleRotation();
        }
        UpdatePosition();
    }

    void HandleRotation()
    {
        float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
        playerTransform.Rotate(Vector3.up * mouseX);
    }

    void UpdatePosition()
    {
        transform.position = playerTransform.position - playerTransform.forward * offset.z +
                             playerTransform.up * offset.y +
                             playerTransform.right * offset.x;

        transform.LookAt(playerTransform);
    }

    public void SetClimbing(bool climbing)
    {
        isClimbing = climbing;
    }

    // Adiciona um método para controlar o bloqueio do mouse
    public void SetMouseLock(bool lockState)
    {
        isMouseLocked = lockState;
        Cursor.lockState = lockState ? CursorLockMode.Locked : CursorLockMode.None;
        Cursor.visible = !lockState;
    }
}
