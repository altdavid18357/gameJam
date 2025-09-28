using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputScript : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public LogicManagerScript logicManager;
    public float upStrength = 1;
    private bool isAlive =  true;

    // Start is called before the first frame update
    void Start()
    {
        logicManager =  GameObject.FindGameObjectWithTag("logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == true && isAlive == true)
        {
            playerBody.velocity = Vector2.up * upStrength;
        }
        
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        logicManager.GameOver();
        isAlive = false;
    }

    
}