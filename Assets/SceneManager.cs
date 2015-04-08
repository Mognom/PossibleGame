using UnityEngine;
using System.Collections;

public class SceneManager : MonoBehaviour {

	public static SceneManager instance;
	private string currentLevel;
	// Use this for initialization
	void Start () {
		if (instance == null)
			instance = this;
		currentLevel = "scene";
	}

	public void resetLevel(){
		Application.LoadLevel (currentLevel);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
