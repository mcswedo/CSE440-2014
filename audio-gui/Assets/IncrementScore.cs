using UnityEngine;
using System.Collections;

public class IncrementScore : MonoBehaviour {

	public int increment = 10;
	
	void OnCollisionEnter2D(Collision2D other) {
		if (other.gameObject.tag == "Player") {
			GameObject.FindGameObjectWithTag("Player").GetComponent<keyboardInput>().score += increment;

			GameObject.FindGameObjectWithTag("Score").GetComponent<GUIText>().text = 
				GameObject.FindGameObjectWithTag("Player").GetComponent<keyboardInput>().score.ToString();
		}
	}
}
