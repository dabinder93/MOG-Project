using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public LevelManager levelmanager;
    public Sprite torch_on; // Drag your first sprite here
    public Sprite torch_off; // Drag your second sprite here

    private SpriteRenderer spriteRenderer;
    private Animator animator;


    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        animator = GetComponent<Animator>();

        if (spriteRenderer.sprite == null) // if the sprite on spriteRenderer is null then
            spriteRenderer.sprite = torch_off; // set the sprite to sprite1
        if(spriteRenderer.sprite = torch_on){
            
        }
    }


    // Update is called once per frame
    void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            levelmanager.currentCheckpoint = gameObject;
            if (spriteRenderer.sprite == torch_off) // if the spriteRenderer sprite = sprite1 then change to sprite2
            {
                spriteRenderer.sprite = torch_on;
            }
        }
    }
}
