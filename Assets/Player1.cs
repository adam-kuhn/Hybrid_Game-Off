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
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("s") || Input.GetKey("down")) 
        {
            rb.AddForce(0, 0, -1000 * Time.deltaTime);
        }

        if (Input.GetKey("w") || Input.GetKey("up")) 
        {
            rb.AddForce(0, 0, 1000 * Time.deltaTime);
        }
	}

    void OnCollisionEnter() 
    {
        Debug.Log("I've been hit");
        rb.useGravity = true;
    }
}
