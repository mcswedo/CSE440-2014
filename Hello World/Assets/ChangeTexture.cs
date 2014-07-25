using UnityEngine;
using System.Collections;

public class ChangeTexture : MonoBehaviour {
	public Sprite sprite1;
	public Sprite sprite2;

	private SpriteRenderer sRenderer;

	void Start () {
		sRenderer = gameObject.GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)) {
			if(sRenderer.sprite == sprite1) {
				sRenderer.sprite = sprite2;
			}
			else if(sRenderer.sprite == sprite2) {
				sRenderer.sprite = sprite1;
			}
		}
	}
}
