using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Controller : MonoBehaviour {

    public float speed = 0;
    public float speed2;
    public float maxSpeed = 4;
    public float jumpForce = 700;
    public bool facingRight = true;
    public bool grounded = false;
    public bool prevGrounded = false;
    public LayerMask groundLayers;
    protected Animator animator;
    public Rigidbody2D rigidBody;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        rigidBody = GetComponent<Rigidbody2D>();
	
	}
    

    // Update is called once per frame
    void FixedUpdate () {


        rigidBody.velocity = new Vector2(speed * maxSpeed, rigidBody.velocity.y);
        animator.SetFloat("Speed", Mathf.Abs(speed));
                
        grounded = Physics2D.OverlapCircle(transform.position, 0.6f, groundLayers);
        if (grounded && !prevGrounded)
        {
            animator.SetTrigger("OnGround");
            animator.ResetTrigger("OffGround");            
        }else if (!grounded && prevGrounded)
        {
            animator.SetTrigger("OffGround");
            animator.ResetTrigger("OnGround");
                    }
        prevGrounded = grounded;


        if (speed > 0 && !facingRight)
        {
            Flip();
        }else if (speed < 0 && facingRight)
        {
            Flip();
        }
	
	}

    

    void Flip()
    {
        facingRight = !facingRight;
        Vector3 flip = transform.localScale;
        flip.x *= -1;
        transform.localScale = flip;
    }

    public void Jump()
    {
        if (grounded)
        {
            rigidBody.AddForce(new Vector2(0, jumpForce));
        }
    }

    public void SetSpeed(float value)
    {
        speed = value * speed2;
    }

}
