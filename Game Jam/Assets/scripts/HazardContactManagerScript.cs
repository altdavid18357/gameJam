using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HazardContactManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnContact(int hazardElement, int playerElement)
    {
        // 1 is fire, 2 is water, 3 is lighting, 4 is earth
        if (hazardElement == playerElement)
        {
            // give powerup??? or prevent this from happening by invalidating same element spawns
        }
        else if (playerElement == (hazardElement - 1) % 4)
        {
            // kill player
        }
        else if (playerElement == (hazardElement + 1) % 4)
        {
            // destroy obstacle
        }
        else if (playerElement == (hazardElement + 2) % 4) // not sure if logic is right here
        {
            // give powerup
        }
    }
}
