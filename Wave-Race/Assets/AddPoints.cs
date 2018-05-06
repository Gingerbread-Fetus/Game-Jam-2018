using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour {

    private int points;
    public GameObject partner;

	// Use this for initialization
	void Start () {
        points = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag.Equals("Arm"))
        {
            Debug.Log("+1 point");
            points += 1;
            gameObject.SetActive(false);
            partner.SetActive(true);
        }
    }
}
