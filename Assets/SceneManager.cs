using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public static SceneManager instance;
	private string currentLevel;
	// Use this for initialization
	void Start () {
		instance = this;
		currentLevel = "scene";
	}

	//Reloads current level
	public void resetLevel(){
		Application.LoadLevel (currentLevel);
	}

	//On death animation and then reset
	public IEnumerator deathTrigger(){
		//Start death animation
		print ("Muerte y destruccion");
		yield return new WaitForSeconds (1.0f);
		resetLevel ();
	}
	
	void OnTriggerEnter2D(Collider2D other){
		//Level completed
		resetLevel ();
	}

	public void died (){
		StartCoroutine(deathTrigger ());
	}
}
