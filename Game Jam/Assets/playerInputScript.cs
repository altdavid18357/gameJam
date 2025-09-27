using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerInputScript : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float upStrength = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == true)
        {
            playerBody.velocity = Vector2.up *  upStrength;
        }
    }
}
