using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {


	public float maxSpeed;
	public float moveForce;
    public float jumpForce;

    public float h;
	public float a;
	public float b;

	string Direction = null;

    private Rigidbody2D body2D;
    private RaycastHit2D groundDetect;

    // Use this for initialization
    void Start () {
        body2D = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void FixedUpdate ()
	{
        Movement();
        PlayerJump();
	}

    void Movement()
    {
        // Cache the horizontal input.
        h = Input.GetAxis("Horizontal");
        a = body2D.velocity.x;
        b = body2D.velocity.y;

        if (h > 0)
        {
            Direction = "right";
        }
        if (h < 0)
        {
            Direction = "left";
        }


        if (Direction == "right")
        {

            body2D.velocity = new Vector2(10, b);
        }

        if (Direction == "left")
        {

            body2D.velocity = new Vector2(-10, b);
        }
        /*if(Mathf.Abs(body2D.velocity.x) > maxSpeed)
			
			body2D.velocity = new Vector2(Mathf.Sign(body2D.velocity.x) * maxSpeed, body2D.velocity.y);*/
    }

    void PlayerJump()
    {
        if (body2D.velocity.y == 0)
            if (Input.GetButton("Jump"))
            {
                body2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            }
    }


}
