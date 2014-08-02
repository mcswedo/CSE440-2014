using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour {

	public int score;

	public GameObject explosion;
	public GameObject playerExplosion;

	private GameController gameController;

	void Start() {
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if(gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController>();
		}
		if(gameController == null) {
			Debug.Log ("Cannot find 'Game Controller' script");
		}
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Boundary") {
			return;
		}
		Instantiate(explosion, transform.position, transform.rotation);

		if(other.tag == "Player") {
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			gameController.GameOver();
		}

		gameController.AddScore(score);
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
