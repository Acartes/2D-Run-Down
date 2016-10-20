using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	public float maxSpeed;
	public float moveForce;

	public float h;
	public float a;
	public float b;

	string Direction = null;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate ()
	{
		// Cache the horizontal input.
		h = Input.GetAxis("Horizontal");

		a = GetComponent<Rigidbody2D> ().velocity.x;
		b = GetComponent<Rigidbody2D> ().velocity.y;

		if (h > 0) {
			Direction = "right";
		}
		if (h < 0) {
			Direction = "left";
		}


		if (Direction == "right") {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (10, b);
		}

		if (Direction == "left") {

			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-10, b);
		}
		/*if(Mathf.Abs(GetComponent<Rigidbody2D>().velocity.x) > maxSpeed)
			
			GetComponent<Rigidbody2D>().velocity = new Vector2(Mathf.Sign(GetComponent<Rigidbody2D>().velocity.x) * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);*/
	}


}
