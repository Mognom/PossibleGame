using UnityEngine;
using System.Collections;

public class SceneControl : MonoBehaviour {
	public PjBehaviour pj;
	private Vector3 initialPos;

	// Use this for initialization
	void Start () {
		initialPos = pj.transform.position;
	}
	

	IEnumerator deathTrigger(){
		//Start death animation
		print ("Muerte y destruccion");
		yield return new WaitForSeconds (3.0f);
		resetScene ();
	}

	private void resetScene(){
		pj.transform.position = initialPos;
	
	}

	void OnTriggerEnter2D(Collider2D other){
		print ("entra");
		StartCoroutine(deathTrigger ());
		print ("sale");
	}

}
