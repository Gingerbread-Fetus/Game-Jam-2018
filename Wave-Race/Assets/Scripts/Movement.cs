using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject arm;
    public string PlayerNumber;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (PlayerNumber.Equals("1"))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.forward, 5, Space.Self);
            }
            if (Input.GetKey(KeyCode.RightArrow))
            {
                arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.back, 5, Space.Self);
            } 
        }
        if (PlayerNumber.Equals("2"))
        {
            if (Input.GetKey(KeyCode.A))
            {
                arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.forward, 5, Space.Self);
            }
            if (Input.GetKey(KeyCode.D))
            {
                arm.GetComponent<Rigidbody>().transform.Rotate(Vector3.back, 5, Space.Self);
            }
        }
    }
}
