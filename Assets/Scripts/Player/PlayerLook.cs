using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLook : MonoBehaviour
{
    public Camera lookCam;
    private float xRotation = 0.0f;

    public float xSensitivity = 40.0f;
    public float ySensitivity = 40.0f;

    public void ProcessLook(Vector2 input)
    {
        float mouseX = input.x;
        float mouseY = input.y;

        // Calculate camera rotation (up and down)
        xRotation -= (mouseY * Time.deltaTime) * ySensitivity;
        xRotation = Mathf.Clamp(xRotation, -80.0f, 80.0f);

        // Apply to camera transformation
        lookCam.transform.localRotation = Quaternion.Euler(xRotation, 0.0f, 0.0f);

        // Look left and right
        transform.Rotate(Vector3.up * (mouseX * Time.smoothDeltaTime) * xSensitivity);
    }
}
