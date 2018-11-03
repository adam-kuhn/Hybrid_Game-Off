using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ground_phys : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        rb.AddForce(0, 20 * Time.deltaTime, 200 * Time.deltaTime);
    }
}
