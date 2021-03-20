using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    public float forwardForce = 1500f, sideForce = 150f;
    // Update is called once per frame
    Boolean left, right;

    void Update() {
        if (Input.GetKey("d"))
        {
            left = true;   
        }    
        
        if (Input.GetKey("a"))
        {
            right = true;   
        }    
        
    }
    void FixedUpdate()
    {
        rigidbody.AddForce(-forwardForce*Time.deltaTime,0,0);
        if (Input.GetKey("d"))
        {
            rigidbody.AddForce(0,0,Time.deltaTime*sideForce);
        }
        if (Input.GetKey("a"))
        {
            rigidbody.AddForce(0,0,-Time.deltaTime*sideForce);
        }
    }
}
