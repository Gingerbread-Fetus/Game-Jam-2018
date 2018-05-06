using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour {

    private int playerOnePoints;
    private int playerTwoPoints;
    public GameObject partner;
    public string PlayerNumber;

    public int getPlayerOnePoints()
    {
        return playerOnePoints;
    }

    public int getPlayerTwoPoints()
    {
        return playerTwoPoints;
    }

	// Use this for initialization
	void Start () {
        playerOnePoints = 0;
        playerTwoPoints = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (PlayerNumber.Equals("1")) {
            if (other.gameObject.tag.Equals("Arm"))
            {
                Debug.Log("+1 point");
                playerOnePoints += 1;
                gameObject.SetActive(false);
                partner.SetActive(true);
            }
        }

        if (PlayerNumber.Equals("2"))
        {
            if (other.gameObject.tag.Equals("Arm"))
            {
                Debug.Log("+1 point");
                playerTwoPoints += 1;
                gameObject.SetActive(false);
                partner.SetActive(true);
            }
        }
    }
}
