using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {

	public float speed = 30f;
	public bool xRotate = false;
	public bool yRotate = false;
	public bool zRotate = true;

	void Update () {
		if(xRotate == true) {
			transform.Rotate(Vector3.left, speed * Time.deltaTime);
		}
		if(yRotate == true) {
			transform.Rotate(Vector3.down, speed * Time.deltaTime);
		}
		if(zRotate == true) {
			transform.Rotate(Vector3.back, speed * Time.deltaTime);
		}

		checkButtons();
	}

	void checkButtons() {
		if(Input.GetKeyDown(KeyCode.Z)) {
			zRotate = !zRotate;
		}
		if(Input.GetKeyDown(KeyCode.X)) {
			xRotate = !xRotate;
		}
		if(Input.GetKeyDown(KeyCode.Y)) {
			yRotate = !yRotate;
		}
	}
}
