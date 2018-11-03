using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public Rigidbody rb;
    //float is a number with decimals
    public float forwardForce = 200f;

    // Use this for initialization
    void Start () 
    {
        rb.useGravity = false;
	}
	
	// Update is called once per frame
    // use FixedUpdate for programming physics
	void FixedUpdate () 
    {
        // inputs go x, y, z
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d") || Input.GetKey("right")) 
        {
            Debug.Log("RIGHT direction");
        }

        if (Input.GetKey("s") || Input.GetKey("down")) 
        {
            Debug.Log("DOWN direction");
        }

        if (Input.GetKey("a") || Input.GetKey("left")) 
        {
            Debug.Log("LEFT direction");
        }

        if (Input.GetKey("w") || Input.GetKey("up")) 
        {
            Debug.Log("FORWARD please");
        }
	}

    void OnCollisionEnter() 
    {
        Debug.Log("I've been hit");
        rb.useGravity = true;
    }
}
