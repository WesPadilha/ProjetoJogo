using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float walkSpeed = 3.0f;
    public float runSpeed = 6.0f;
    public float sneakSpeed = 1.5f;
    public float rotationSpeed = 50.0f;
    public float jumpForce = 8.0f;
    public float gravity = 30.0f;
    public float boostSpeed = 10.0f;
    public float boostDuration = 0.2f;

    private CharacterController characterController;
    private Vector3 motion;
    private bool isClimbing = false;
    private Transform ladderTransform;
    private bool canRotate = true;

    private bool isBoosting = false;
    private float boostTimer = 0.0f;

    private CameraController cameraController;
    private PlayerBook playerBook;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cameraController = Camera.main.GetComponent<CameraController>();
        playerBook = GetComponent<PlayerBook>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            isClimbing = true;
            ladderTransform = other.transform;
            cameraController.SetClimbing(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ladder"))
        {
            isClimbing = false;
            ladderTransform = null;
            cameraController.SetClimbing(false);
        }
    }

    void Update()
    {
        if (playerBook.IsBookOpen())
        {
            canRotate = false; 
        }
        else
        {
            canRotate = true;
        }

        if (isClimbing)
        {
            float verticalClimb = Input.GetAxis("Vertical");
            Vector3 climbMove = new Vector3(0, verticalClimb, 0) * walkSpeed;
            characterController.Move(climbMove * Time.deltaTime);

            if (Input.GetKeyDown(KeyCode.E))
            {
                isClimbing = false;
                ladderTransform = null;
                canRotate = true;
            }

            if (canRotate)
            {
                characterController.transform.rotation = Quaternion.Euler(0, characterController.transform.rotation.eulerAngles.y, 0);
            }
            return;
        }

        if (Input.GetKey(KeyCode.LeftControl) && Input.GetKeyDown(KeyCode.Space))
        {
            isBoosting = true;
            boostTimer = 0.0f;
        }

        if (isBoosting)
        {
            boostTimer += Time.deltaTime;

            float horizontalBoost = Input.GetAxis("Horizontal") * boostSpeed;
            float verticalBoost = Input.GetAxis("Vertical") * boostSpeed;

            Vector3 boostMove = transform.TransformDirection(new Vector3(horizontalBoost, 0, verticalBoost));

            characterController.Move(boostMove * Time.deltaTime);

            if (boostTimer >= boostDuration)
            {
                isBoosting = false;
            }
        }
        else
        {
            float speed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : Input.GetKey(KeyCode.LeftControl) ? sneakSpeed : walkSpeed;
            float horizontalMovement = Input.GetAxis("Horizontal") * speed;
            float verticalMovement = Input.GetAxis("Vertical") * speed;

            Vector3 desiredMove = transform.TransformDirection(new Vector3(horizontalMovement, 0, verticalMovement));
            motion.x = desiredMove.x;
            motion.z = desiredMove.z;

            if (characterController.isGrounded)
            {
                motion.y = -0.5f;
                if (Input.GetButtonDown("Jump"))
                {
                    motion.y = jumpForce;
                }
            }

            if (canRotate)
            {
                float mouseX = Input.GetAxis("Mouse X");
                transform.Rotate(Vector3.up * mouseX * rotationSpeed * Time.deltaTime);
            }

            if (!characterController.isGrounded)
            {
                motion.y -= gravity * Time.deltaTime;
            }

            characterController.Move(motion * Time.deltaTime);
        }
    }
}
