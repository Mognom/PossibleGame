using UnityEngine;
using System.Collections;

public class ObstacleCollision : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		other.attachedRigidbody.velocity = Vector2.zero;
		other.GetComponent<SpriteRenderer> ().sprite = null;
		SceneManager.instance.died ();
		//Destroy (other.gameObject);


	}


}
