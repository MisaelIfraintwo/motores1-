using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBodyMovement : MonoBehaviour
{
    public float speed;
    public Rigidbody rigidBody;

    public Vector2 inputVector;
    // Start is called before the first frame update
    void Start()
    {   
        rigidBody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");
        rigidBody.AddForce(inputVector.x * speed, 0f, inputVector.y * speed, ForceMode.Impulse);
    }
}
