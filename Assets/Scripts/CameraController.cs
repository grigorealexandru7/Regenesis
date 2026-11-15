using UnityEngine;
using UnityEngine.InputSystem;

public class CameraController : MonoBehaviour
{
    public float Sensitivity = 5f;
    private float xRotation = 0f;
    

    void Start()
    {
       Cursor.lockState = CursorLockMode.Locked;
       Cursor.visible = true;
       //Cursor.lockState = CursorLockMode.None;
       //Cursor.visible = true;
    }

    void Update()
    {
        
        if (Mouse.current == null)
            return;

        Vector2 mouseDelta = Mouse.current.delta.ReadValue();

        float mouseX = mouseDelta.x * Sensitivity * Time.deltaTime;
        float mouseY = mouseDelta.y * Sensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, 10f, 45f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        transform.parent.Rotate(Vector3.up * mouseX);
    }
}