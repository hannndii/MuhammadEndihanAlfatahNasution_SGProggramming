using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float speed = 5f;
    public VariableJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float HorizontalInput = joystick.Horizontal;
        float VerticalInput = joystick.Vertical;

        Vector3 move = new Vector3(HorizontalInput, 0f, VerticalInput) * speed * Time.deltaTime;
        // Vector3 = 

        transform.Translate(move);
    }
}
