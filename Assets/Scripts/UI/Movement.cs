using UnityEngine;

public class SimpleWalker : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5.0f;
    public float rotateSpeed = 100.0f;

    void Update()
    {
        // 1. Get Input from Keyboard (WASD or Arrow Keys)
        // "Vertical" = W/S or Up/Down arrows
        // "Horizontal" = A/D or Left/Right arrows
        float moveInput = Input.GetAxis("Vertical"); 
        float turnInput = Input.GetAxis("Horizontal");

        // 2. Calculate Rotation (Turning left/right)
        // We rotate around the Y axis (the Up axis)
        float rotationAmount = turnInput * rotateSpeed * Time.deltaTime;
        transform.Rotate(0, rotationAmount, 0);

        // 3. Calculate Movement (Forward/Back)
        // Vector3.forward is relative to the direction the capsule is facing
        Vector3 moveDirection = Vector3.forward * moveInput * moveSpeed * Time.deltaTime;
        
        // Apply the movement
        transform.Translate(moveDirection);
    }
}