using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointManager : MonoBehaviour {

    public LevelManager levelmanager;
    private Animator anim;


    // Use this for initialization
    void Start()
    {
        levelmanager = FindObjectOfType<LevelManager>();
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update () {
		
	}

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name == "Player")
        {
            levelmanager.currentCheckpoint = gameObject;
            anim.SetBool("isActivated", true);
        }
    }
}
