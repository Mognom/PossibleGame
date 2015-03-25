using UnityEngine;
using System.Collections;

public class CameraBehaviour : MonoBehaviour {

	public Transform player;
	private float cameraY = 0f;
	private float dif = 1.5f;
	private float velocity = 0;

	void start(){

		cameraY = transform.position.y;
	}
	
	// Update is called once per frame
	void Update () {

		float x = player.position.x;
		cameraY = Mathf.SmoothDamp (cameraY, player.position.y, ref velocity, 0.15f);

		//values of the initial offset of the camera
		transform.position = new Vector3 (x+4.8f, cameraY+0.5f, -1);

		//-0.2, 2.0
		//-5, 0
	}
}
