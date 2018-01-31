using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckpoint;
    private PlayerController player;

	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RespawnPlayer()
    {
        Debug.Log("Player respawned");
        //player.transform.position = currentCheckpoint.transform.position;
        player.transform.position = new Vector2(currentCheckpoint.transform.position.x, currentCheckpoint.transform.position.y + 0.6f);

    }

    public void FinishedGame()
    {
        Application.LoadLevel("Level/StartMenu");
    }
}
