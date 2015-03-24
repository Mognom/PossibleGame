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

		if (rb.velocity.magnitude < 3) {
			print ("why dead?");
			print (rb.velocity.magnitude);
		}
		if (Input.GetKey (KeyCode.W) && grounded >0 ) {
			rb.AddForce (jumpVector * 10, ForceMode2D.Impulse);
			grounded = 0;
		}
	}


	void OnCollisionEnter2D(Collision2D coll){
		grounded  = 1;
	}

	void OnCollisionExit2D(Collision2D coll){
		grounded = 0;
	}

}
