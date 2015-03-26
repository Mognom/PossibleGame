using UnityEngine;
using System.Collections;

public class PjBehaviour : MonoBehaviour {
	private Vector2 jumpVector, moveVect;
	private Rigidbody2D rb;
	private ushort grounded;

	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
		grounded = 0;
		jumpVector = new Vector2 (0, 1);
		moveVect = new Vector2 (1, 0);
		rb.velocity = moveVect*5;
		//rb.AddForce(moveVect * 70);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Input.GetKey (KeyCode.W) && grounded >0 ) {
			rb.AddForce (jumpVector * 10, ForceMode2D.Impulse);
			grounded = 0;
		}
	}

	void OnCollisionEnter2D(Collision2D coll){
		//Calculate the ground position
		float lol = (int)( transform.rotation.eulerAngles.z/ 90) * 90;
		float y = coll.contacts [0].point.y + GetComponent<Renderer>().bounds.size.y/2 -0.1f;//Make sure it touches.
	
		//Set the new position
		transform.eulerAngles = new Vector3(0,0,lol);
		transform.position = new Vector3(transform.position.x,y,0);//-0.35f

		//Reset al movement
		rb.angularVelocity = 0f;
		rb.velocity = moveVect*5;

		//Allow jump
		grounded  = 1;
	}

	void OnCollisionExit2D(Collision2D coll){
		//Disable jump
		grounded = 0;
		// Add angularVelocity
		rb.AddTorque (-19.0f);
	}

}
