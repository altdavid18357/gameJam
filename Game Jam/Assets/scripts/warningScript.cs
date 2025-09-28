using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class warningScript : MonoBehaviour
{
    public GameObject player;

    public int warningTimer;
    public int delayTimer;

    private float timer = 0;

    public GameObject bolt;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < warningTimer)
        {
            transform.position = new Vector3(transform.position.x, player.transform.position.y, transform.position.z);
            timer += Time.deltaTime;
        }
        else if (timer > delayTimer + warningTimer)
        {
            bolt.transform.position = new Vector3(bolt.transform.position.x, transform.position.y, bolt.transform.position.z);
            bolt.SetActive(true);
            gameObject.SetActive(false);
        }
        else
        {
            timer += Time.deltaTime;
        }
        
        
    }
}
