using UnityEngine;

public class movments : MonoBehaviour
{
    public float xRotation = 0f; // Horizontal rotation (left/right)
    public float yRotation = 0f; // Vertical rotation (up/down)
    public float mouseSensitivity = 100f;
    public Transform playerBody;

    void Start()
    {
       
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        // Rotate up and down (clamp to prevent flipping)
        yRotation -= mouseY;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        // Rotate left and right
        xRotation += mouseX;

        // Apply rotation
        transform.localRotation = Quaternion.Euler(yRotation, 0f, 0f); // Camera rotation (up/down)
        playerBody.Rotate(Vector3.up * mouseX); // Player rotation (left/right)
    }
}
