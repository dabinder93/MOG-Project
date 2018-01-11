using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float maxSpeed = 4;
    public float jumpForce = 550;

    private Rigidbody2D rb2d;
    private Animator anim;

    public bool lookingRight = true;
    public bool jump = false;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("isGrounded", true);

	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
	}


    // wird in festem intervall aufgerufen
    private void FixedUpdate()
    {
        float hor = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(hor * maxSpeed, rb2d.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(hor));
        if (hor > 0 && !lookingRight || hor < 0 && lookingRight)
        {
            Flip();
        }

        if (jump)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            jump = false;
        }


        
    }


    public void Flip()
    {
        lookingRight = !lookingRight;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
    }
}
