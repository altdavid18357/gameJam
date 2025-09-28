using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballSpawnScript : MonoBehaviour
{
    public GameObject fireball;

    private float spawnRate = 2;

    private float timer = 0;
    private float heightOffset = 3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            float lowestPoint = transform.position.y - heightOffset;
            float highestPoint = transform.position.y + heightOffset;
            
            Instantiate(fireball, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), Quaternion.Euler(0, 180, 0));
            
            timer = 0;
            UpdateSpawnRate();
        }
    }

    void UpdateSpawnRate()
    {
        spawnRate = Random.Range(1, 5);
    }
    
}
