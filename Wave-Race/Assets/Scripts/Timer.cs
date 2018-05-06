using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    public GameObject manager;
    private TheManager ourManager;
    private int time;
	// Use this for initialization
	void Start () {
        ourManager = manager.GetComponent<TheManager>();
        time = (int)ourManager.time;
        GetComponent<Text>().text = time.ToString();
	}
	
	// Update is called once per frame
	void Update () {
        //Get current time from manager
        //GetComponent<Text>().text = manager.GetComponent<TheManager>().time.ToString();
        if (ourManager.time >= 0)
        {
            time = (int)ourManager.time;
            GetComponent<Text>().text = time.ToString(); 
        }
    }
}
