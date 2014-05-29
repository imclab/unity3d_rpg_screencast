using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public float moveSpeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 movement = Vector2.zero;

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (Input.GetButton("Horizontal")) {
			movement.x = h;
		} else if (Input.GetButton("Vertical")) {
			movement.y = v;
		}

		transform.Translate(movement * moveSpeed * Time.deltaTime);
	
	}
}
