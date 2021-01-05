using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;
    public float horizontalInput;
    public float rudderSpeed;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        // move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed);

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * verticalInput);

        // tilt the plane left to right based on left and right keys
        transform.Rotate(Vector3.back * rotationSpeed * Time.deltaTime * horizontalInput);

        if (Input.GetKey("e"))
        {
            transform.Rotate(Vector3.up * rudderSpeed * Time.deltaTime);
        }

        if (Input.GetKey("q"))
        {
            transform.Rotate(Vector3.down * rudderSpeed * Time.deltaTime);
        }
    }
}
