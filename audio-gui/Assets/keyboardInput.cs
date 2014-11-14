using UnityEngine;
using System.Collections;

public class keyboardInput : MonoBehaviour {

	public int score = 0;

	public float jumpSpeed;
	public AudioClip jumpSound;
	public float moveSpeed = .05f;
	private bool canJump = false;
	//private bool canMove = true;

	void OnCollisionEnter2D(Collision2D collision) {
			if (collision.gameObject.tag == "Ground") {  // Detects collision with tagged gameObject
					canJump = true;

			}
			//if (collision.gameObject.tag == "Wall") {  // Detects collision with tagged gameObject
			//		canMove = false;
			//}

	}
	
	// Update is called once per frame
	void Update () {
		Vector3 tempPosition = transform.position;
		//if (canMove) {
				if (Input.GetAxis ("Horizontal") > 0) {
						tempPosition.x += moveSpeed;
					//	canMove = true;
				}
				if (Input.GetAxis ("Horizontal") < 0) {
						tempPosition.x -= moveSpeed;
						//canMove = true;
				}
				if (Input.GetButtonDown ("Jump") && canJump) {
						rigidbody2D.AddForce (Vector3.up * jumpSpeed);
						gameObject.audio.PlayOneShot(jumpSound);
						canJump = false;
				}
		//}
		transform.position = tempPosition;
	}
}
