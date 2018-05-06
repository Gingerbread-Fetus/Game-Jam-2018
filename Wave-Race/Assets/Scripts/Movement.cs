using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject arm;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.LeftArrow)) { 
		    arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.forward, 5, Space.Self);
        }
	    if (Input.GetKey(KeyCode.RightArrow))
	    {
	        arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.back, 5, Space.Self);
	    }
    }
}
