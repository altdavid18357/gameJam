using UnityEngine;

public class playerInputScript : MonoBehaviour
{
    public Rigidbody2D playerBody;
    public float upStrength = 1;
    private bool isAlive =  true;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey == true && isAlive == true)
        {
            playerBody.velocity = Vector2.up * upStrength;
        }
        
    }

    public void SetAlive(bool alive)
    {
        isAlive = alive;
    }
}