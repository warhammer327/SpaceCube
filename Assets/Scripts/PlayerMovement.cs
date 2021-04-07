using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rigidbody;
    public float forwardForce = 1500f;
    public static float newSideForce=100f;
    // Update is called once per frame
    Boolean left, right, gamePaused = true;

    public void AdjustSensitivity(float newSpeed)
    {
        newSideForce = newSpeed;

    }
    void Update()
    {
        left = false;
        right = false;
        if (Input.GetKey("d"))
        {
            left = true;
        }

        if (Input.GetKey("a"))
        {
            right = true;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(gamePaused)
            {
                Time.timeScale = 0f; 
                gamePaused = false;
            }
            else
            {
                Time.timeScale = 1f;
                gamePaused = true;
            }
        }

        Debug.Log("Hello newSideForce is " + newSideForce);
    }
    void FixedUpdate()
    {

        rigidbody.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        if (left)
        {
            rigidbody.AddForce(0, 0, Time.deltaTime * newSideForce, ForceMode.VelocityChange);
            Debug.Log("ON GAME " + newSideForce);
        }
        if (right)
        {
            rigidbody.AddForce(0, 0, -Time.deltaTime * newSideForce, ForceMode.VelocityChange);
            Debug.Log("ON GAME " + newSideForce);
        }
        if (rigidbody.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
