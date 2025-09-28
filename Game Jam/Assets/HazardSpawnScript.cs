using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardSpawnScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float spawnRate; // is a fraction out of 10, represent the chance for each timer cycle for an obstacle to spawn
    public int spawnTimer;
    private float timer = 0;
    public GameObject lightning;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > spawnTimer)
        {
            SpawnHazard();
            timer = 0;
        }
        else
        {
            timer += Time.deltaTime;
        }
    }

    void SpawnHazard()
    {
        int roll = Random.Range(0, 10);
        if (roll <= spawnRate)
        {
            Instantiate(lightning, new Vector3((float)6.7, 0, 0), lightning.transform.rotation);
        }
        
        
    }
}
