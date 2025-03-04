using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMooove : MonoBehaviour
{
    private float vertical;
    private float horizontal;
    public float speed;
    public float offset;
    public float verticalRotationLimit;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Mouse X");
        transform.Rotate(Vector3.up, horizontalInput * speed * Time.deltaTime);

        float verticalInput = Input.GetAxis("Mouse Y");
        vertical -= verticalInput * speed * Time.deltaTime;
        vertical = Mathf.Clamp(vertical, -verticalRotationLimit, verticalRotationLimit);

        transform.localRotation = Quaternion.Euler(vertical, transform.localEulerAngles.y, 0f);
    }
}
