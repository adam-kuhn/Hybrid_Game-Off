using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour {

    public Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb.useGravity = false;
	}
	
	// Update is called once per frame
    // use FixedUpdate for programming physics
	void FixedUpdate () {
        rb.AddForce(0, 20 * Time.deltaTime, 200 * Time.deltaTime);
	}

    void OnCollisionEnter() {
        Debug.Log("I've been hit");
        rb.useGravity = true;
    }
}
