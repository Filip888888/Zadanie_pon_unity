using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class WSAD : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float mouseSensitivity = 1000f;
    public Transform cameraTransform;

    private Rigidbody rb;
    private float xRotation = 0f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        // Zablokuj i ukryj kursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // ---- OBRACANIE MYSZK¥ ----
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Obrót gracza w poziomie
        transform.Rotate(Vector3.up * mouseX);

        // Obrót kamery w pionie
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -80f, 80f);
        cameraTransform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
    }

    void FixedUpdate()
    {
        // ---- RUCH WSAD ----
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        rb.MovePosition(rb.position + move * moveSpeed * Time.fixedDeltaTime);
    }
}
