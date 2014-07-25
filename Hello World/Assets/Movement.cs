using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float speed = .05f;

	private Vector3 temp;

	void Start () {
		temp = transform.position;
	}

	void Update () {
		temp = transform.position;
		
		if(Input.GetKey(KeyCode.A)) {
			temp.x -= speed;
		}
		if(Input.GetKey(KeyCode.D)) {
			temp.x += speed;
		}
		if(Input.GetKey(KeyCode.S)) {
			temp.y -= speed;
		}
		if(Input.GetKey(KeyCode.W)) {
			temp.y += speed;
		}
		if(Input.GetKey(KeyCode.Q)) {
			temp.z -= speed;
		}
		if(Input.GetKey (KeyCode.E)) {
			temp.z += speed;
		}

		transform.position = temp;
	}
}
