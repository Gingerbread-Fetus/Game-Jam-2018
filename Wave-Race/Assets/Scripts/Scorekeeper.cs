using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scorekeeper : MonoBehaviour {
    public GameObject manager;
    private TheManager scoreManager;
    private Text txt;
	// Use this for initialization
	void Start () {
        scoreManager = manager.GetComponent<TheManager>();
        txt = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        string scoreText = scoreManager.ReturnPoints(gameObject.tag).ToString();
        txt.text = scoreText;
	}


}
