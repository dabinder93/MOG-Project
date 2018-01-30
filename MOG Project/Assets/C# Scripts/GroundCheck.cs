using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    private PlayerController player;
    private Animator anim;
    // Use this for initialization
    void Start () {
        player = gameObject.GetComponentInParent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.isGrounded = true;
        player.groundCollisionCount++;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        player.isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        player.isGrounded = false;
        player.groundCollisionCount--;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
