using UnityEngine;

public class FreeCamera : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotateSpeed = 100f;

    void Update()
    {
        float xMovement = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        float zMovement = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        float yMovement = 0f;

        if (Input.GetKey(KeyCode.E))
        {
            yMovement = moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            yMovement = -moveSpeed * Time.deltaTime;
        }

        transform.Translate(new Vector3(xMovement, yMovement, zMovement));

        float xRotation = Input.GetAxis("Mouse X") * rotateSpeed * Time.deltaTime;
        float yRotation = Input.GetAxis("Mouse Y") * rotateSpeed * Time.deltaTime;

        transform.Rotate(new Vector3(-yRotation, xRotation, 0));
    }
}