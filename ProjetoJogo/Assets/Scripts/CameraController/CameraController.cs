using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerTransform;
    public float rotationSpeed = 2.0f;
    public Vector3 offset = new Vector3(0, 0, 0);
    private bool isClimbing = false;

    void LateUpdate()
    {
        if (!isClimbing)
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
}
