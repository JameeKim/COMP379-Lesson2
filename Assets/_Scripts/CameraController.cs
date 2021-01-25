using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float mouseSensitivity = 1000.0f;
    public Transform playerBody;

    private float rotationX;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX -= mouseY;
        rotationX = Mathf.Clamp(rotationX, -90.0f, 90.0f);

        transform.localRotation = Quaternion.Euler(rotationX, 0.0f, 0.0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
