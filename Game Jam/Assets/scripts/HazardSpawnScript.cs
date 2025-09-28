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
    public GameObject fireball;
    public GameObject tree;
    public GameObject waterfall;
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
            int hazardRoll = Random.Range(1, 5);
            
            if (hazardRoll == 1)
            {
                SpawnFireball();
            }
            else if (hazardRoll == 2)
            {
                SpawnWater();
            }
            else if (hazardRoll == 3)
            {
                SpawnLightning();
            }
            else if (hazardRoll == 4)
            {
                SpawnEarth();
            }
            
        }
        
        
    }

    void SpawnFireball()
    {
        float heightOffset = 3;
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
            
        Instantiate(fireball, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.Euler(0, 180, 0));
    }

    void SpawnLightning()
    {
        Instantiate(lightning, new Vector3((float)6.7, 0, 0), lightning.transform.rotation);
    }

    void SpawnEarth()
    {
        // randomly chooses if its on floor or ceiling
        int rotation = Random.Range(0, 2);
        if (rotation == 0)
        {
            Instantiate(tree, new Vector3(9, (float)-0.4, 0), tree.transform.rotation);
        }
        else if (rotation == 1)
        {
            Instantiate(tree, new Vector3(9, (float)0.43, 0), new Quaternion(0, 0, 180, 0));
        }

    }

    void SpawnWater()
    {
        float height = Random.Range(-2.0f, 2.1f);
        
        Instantiate(waterfall, new Vector3(9, height, 0), waterfall.transform.rotation);
    }
}
