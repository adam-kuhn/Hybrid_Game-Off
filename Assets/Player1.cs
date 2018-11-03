using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public Rigidbody rb;
    //float is a number with decimals "f" after number means float
    public float forwardForce = 200f;
    public float sidewaysMovement = 1200;
    public float forwardMovement = 1500;
    public float backwardMovement = -1000f;

    public bool moveRight = false;
    public bool moveLeft = false;
    public bool moveUp = false;
    public bool moveBack = false;


    // Use this for initialization
    void Start () 
    {
   
    }

    void Update()
    {
        // below is sames as 
        // if (Input.GetKey("d") || Input.GetKey("right")) { moveRight = true }
        // | will only compute false if both values are false
        // so if moveRight is false and getKey is true ==> true will be retured and a move occurs
        moveRight |= Input.GetKey("d") || Input.GetKey("right");
        // below is same as
        // if (Input.GetKeyUp("d") || Inpute.GetKeyUp("right") { moveRight = false }
        // & will onle compute true if both values are true
        // so if moveRight is true and key up is false (one key up will be false the other will be true), moveRight is set to false and move stops
        moveRight &= !Input.GetKeyUp("d") && !Input.GetKeyUp("right");

        moveLeft |= Input.GetKey("a") || Input.GetKey("left");
        moveLeft &= !Input.GetKeyUp("a") && !Input.GetKeyUp("left");
        //if (Input.GetKey("a") || Input.GetKey("left")) 
        //{
        //    moveLeft = true;

        //}
        //if (Input.GetKeyUp("a") || Input.GetKeyUp("left"))
        //{
        //    moveLeft = false;
        //}
        moveUp |= Input.GetKey("w") || Input.GetKey("up");
        moveUp &= !Input.GetKeyUp("w") && !Input.GetKeyUp("up");

        moveBack |= Input.GetKey("s") || Input.GetKey("down");
        moveBack &= !Input.GetKeyUp("s") && !Input.GetKeyUp("down");
    }

    // Update is called once per frame
    // use FixedUpdate for programming physics
    void FixedUpdate () 
    {
        // inputs go x, y, z
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (moveRight) 
        {
            rb.AddForce(sidewaysMovement * Time.deltaTime, 0, 0);
        }

        if (moveLeft)
        {
            rb.AddForce(-sidewaysMovement * Time.deltaTime, 0, 0);
        }

        if (moveBack) 
        {
            rb.AddForce(0, 0, backwardMovement * Time.deltaTime);
        }

        if (moveUp) 
        {
            rb.AddForce(0, 0, forwardMovement * Time.deltaTime);
        }
	}

    void OnCollisionEnter() 
    {
        Debug.Log("I've been hit");
    }
}
