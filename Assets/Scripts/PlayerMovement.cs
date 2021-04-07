using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    public float forwardForce = 1500f;
    public static float newSideForce=25f;
    // Update is called once per frame
    Boolean left, right, gamePaused = true;
    public GameObject pauseLevelUI;
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
                pauseLevelUI.SetActive(true);
                gamePaused = false;
            }
            else
            {
                Time.timeScale = 1f;
                pauseLevelUI.SetActive(false);
                gamePaused = true;
            }
        }

        //Debug.Log("Hello newSideForce is " + newSideForce);
    }
    void FixedUpdate()
    {

        rb.AddForce(-forwardForce * Time.deltaTime, 0, 0);
        if (left)
        {
            rb.AddForce(0, 0, Time.deltaTime * newSideForce, ForceMode.VelocityChange);
            //Debug.Log("ON GAME " + newSideForce);
        }
        if (right)
        {
            rb.AddForce(0, 0, -Time.deltaTime * newSideForce, ForceMode.VelocityChange);
            //Debug.Log("ON GAME " + newSideForce);
        }
        if (rb.position.y < -2f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
