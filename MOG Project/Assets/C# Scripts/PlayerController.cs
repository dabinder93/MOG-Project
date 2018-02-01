using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {


    public float maxSpeed = 3;
    public float jumpForce = 450;

    private Rigidbody2D rb2d;
    private Animator anim;

    public bool lookingRight = true;
    public bool jump = false;
    public int groundCollisionCount = 0;
    public bool isGrounded;
    private float horizontalAxisValue = 0;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetBool("Grounded", true);
	}
	
	// Update is called once per frame
	void Update () {
        anim.SetInteger("CollisionCount", groundCollisionCount);
        anim.SetBool("Grounded", isGrounded);

#if UNITY_STANDALONE || UNITY_WEBPLAYER

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            //jump = true;
            Jump();
        }

        Move(Input.GetAxisRaw("Horizontal"));
        Debug.Log(Input.GetAxisRaw("Horizontal"));
        /*if (jump) {
            Jump();
        }*/
#endif

#if UNITY_ANDROID
        Move(horizontalAxisValue);

#endif
    }
    public void setHorizontalAxisValue(float value)
    {
        horizontalAxisValue = value;
    }

    
    public void Move(float moveInput) {
        Debug.Log(moveInput);
        float hor = moveInput;
        rb2d.velocity = new Vector2(hor * maxSpeed, rb2d.velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(hor));
        if (hor > 0 && !lookingRight || hor < 0 && lookingRight) {
            Flip();
        }
    }

    public void Jump() {

        if (isGrounded) {
            rb2d.AddForce(new Vector2(0, jumpForce));
            anim.SetBool("Grounded", false);
            //jump = true;
        }
        //rb2d.AddForce(new Vector2(0, jumpForce));
        //jump = false;
        //anim.SetBool("Grounded", false);
    }

    // wird in festem intervall aufgerufen
    private void FixedUpdate()
    {
        /*
        float hor = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(hor * maxSpeed, rb2d.velocity.y);

        Move(Input.GetAxis("Horizontal"));

        anim.SetFloat("Speed", Mathf.Abs(hor));
        if (hor > 0 && !lookingRight || hor < 0 && lookingRight)
        {
            Flip();
        }

        if (jump)
        {
            rb2d.AddForce(new Vector2(0, jumpForce));
            jump = false;
            anim.SetBool("Grounded", false);
            
            Jump();
        }   
        */
    }

    public void Flip()
    {
        lookingRight = !lookingRight;
        Vector3 myScale = transform.localScale;
        myScale.x *= -1;
        transform.localScale = myScale;
    }
}
