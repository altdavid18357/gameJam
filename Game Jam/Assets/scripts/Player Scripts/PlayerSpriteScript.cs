using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteScript : MonoBehaviour
{
    public PlayerLogicManager playerLogicManager;
    public SpriteRenderer spriteRenderer;
    public playerInputScript playerInput;

    public Sprite[] sprites;
    // Start is called before the first frame update
    void Start()
    {
        // get reference to player logic manager
        playerLogicManager =  GameObject.FindGameObjectWithTag("Logic").GetComponent<PlayerLogicManager>();
        
        // assign random element and sprite (0: fire, 1: water, 2: lightning, 3: earth)
        int element = Random.Range(0, 4);
        
        // render appropriate sprite
        RenderSprite(element);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerInput.SetAlive(false);
        playerLogicManager.GameOver();
    }

    void RenderSprite(int element)
    {
        spriteRenderer.sprite = sprites[element];
    }
}
