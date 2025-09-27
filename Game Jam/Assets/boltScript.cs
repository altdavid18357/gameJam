using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boltScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float lifetime;
    private float timer = 0;
    public GameObject parentLightning;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > lifetime)
        {
            Destroy(parentLightning);
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
    }
}
