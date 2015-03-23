using UnityEngine;
using System.Collections;

public class PjBehaviour : MonoBehaviour {
	Vector2 jumpVector, moveVect;
	Rigidbody2D rb;
	ushort grounded;
	// Use this for initialization
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
		grounded = 0;
		jumpVector = new Vector2 (0, 1);
		moveVect = new Vector2 (1, 0);
		rb.AddForce(moveVect * 70);

	}
	
	// Update is called once per frame
	void FixedUpdate () {
		//rb.AddForce(moveVect * 1);
		if (Input.GetKey (KeyCode.W) && grounded >0 ) {
			rb.AddForce (jumpVector * 120);
			grounded--;
		}
	}

	void OnCollisionStay2D(Collision2D coll){

		switch (coll.gameObject.tag) {
		case "ground":
			grounded  = 1;
			break;
		case "doom":
			print("tasmuerto");
			break;
		default:
			break;
		}
	}

}
