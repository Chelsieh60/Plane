using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed = 0;
    public float rotationSpeed = 1.0f;
    public float verticalInput;
    public float forwardInput;

    
    // Start is called before the first frame update
    void Start()
    {
    

    }

    // Update is called once per frame
    void FixedUpdate()
    {

        verticalInput = Input.GetAxis("Vertical");
        forwardInput = Input.GetAxis("Horizontal");
        // move the plane forward at a constant rate
        if (Input.GetKeyDown(KeyCode.D)){
            speed = 15.0f;

        }
        else if (Input.GetKeyUp(KeyCode.D)){
            speed = 0;
        }
        transform.Translate(Vector3.forward * speed * Time.deltaTime * forwardInput);
        

        // tilt the plane up/down based on up/down arrow keys
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * verticalInput);
        
    }
}
