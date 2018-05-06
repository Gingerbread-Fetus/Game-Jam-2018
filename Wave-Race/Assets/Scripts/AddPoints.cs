﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddPoints : MonoBehaviour
{

    private int points;
    public GameObject partner;
    public GameObject gameManager;

    private TheManager manager;

    // Use this for initialization
    void Start()
    {
        manager = gameManager.GetComponent<TheManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (manager.gameOver == true)
        {
            gameObject.SetActive(false);
            partner.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        Debug.Log("+1 point");
        points += 1;
        BoxCollider toChange = GetComponent<BoxCollider>();
        toChange.enabled = false;
        toChange = partner.GetComponent<BoxCollider>();
        toChange.enabled = true;
        //partner.SetActive(true);

        //Change Material on cube
        //Fetch the Renderer from the GameObject
        Renderer rend = GetComponent<Renderer>();

        //Set the main Color of the Material to red
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.red);

        //Find the Specular shader and change its Color to green
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.green);

        //Change Material on partner cube.
        rend = partner.GetComponent<Renderer>();

        //Set the main Color of the Material to red
        rend.material.shader = Shader.Find("_Color");
        rend.material.SetColor("_Color", Color.green);

        //Find the Specular shader and change its Color to green
        rend.material.shader = Shader.Find("Specular");
        rend.material.SetColor("_SpecColor", Color.red);

        //Send message to game manager to increase player's points.
        manager = gameManager.GetComponent<TheManager>();
        manager.ScorePoint(other.tag);
    }
}