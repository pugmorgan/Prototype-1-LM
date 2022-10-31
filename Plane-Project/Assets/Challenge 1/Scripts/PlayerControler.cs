using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    // Private Varibles
    private float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player imput
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We Move the vehicle Forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * horizontalInput);
        // We turn the vehicle
        transform.Rotate(Vector3.left, Time.deltaTime * turnSpeed * forwardInput);
    }
}
