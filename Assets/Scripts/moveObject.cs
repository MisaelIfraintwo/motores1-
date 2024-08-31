using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveObject : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 newPosition;

    public float speed;

    public Vector2 inputVector;
    void Start()
    {
        Debug.Log("Game start");

        
    }

    // Update is called once per frame
    void Update()
    {

        inputVector.x = Input.GetAxis("Horizontal");
        Debug.Log("GAme running");
        if (Input.GetKeyDown(KeyCode.P))
        {
            Debug.Log("p key pressed");
            transform.position = newPosition;
        }
        if (Input.GetKey(KeyCode.W)) {
           transform.Translate(0f , 0f , speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0f, 0f, -speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);
        }
    }
}
