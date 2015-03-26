using UnityEngine;
using System.Collections;

public class FloorBehaviour : MonoBehaviour {

	private Rigidbody2D rb;
	void Start () {
		rb = this.gameObject.GetComponent<Rigidbody2D> ();
		rb.velocity = new Vector2 (1, 0)*5;

	}
	
	// Update is called once per frame
	void FixedUpdate () {
	}
}
