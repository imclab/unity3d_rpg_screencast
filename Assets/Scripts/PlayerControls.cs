using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	public float moveSpeed = 10;
	public Animator animator;
	public Direction direction = Direction.Down;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 movement = Vector2.zero;
		string animationClip = "CharacterIdleDown";

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

		if (Input.GetButton("Horizontal")) {
			movement.x = h;

			if (h < 0) {
				animationClip = "CharacterWalkLeft";
				direction = Direction.Left;
			} else {
				animationClip = "CharacterWalkRight";
				direction = Direction.Right;
			}

		} else if (Input.GetButton("Vertical")) {
			movement.y = v;

			if (v < 0) {
				animationClip = "CharacterWalkDown";
				direction = Direction.Down;
			} else {
				animationClip = "CharacterWalkUp";
				direction = Direction.Up;
			}
		} else {
			if (direction == Direction.Left) {
				animationClip = "CharacterIdleLeft";
			} else if (direction == Direction.Right) {
				animationClip = "CharacterIdleRight";
			} else if (direction == Direction.Up) {
				animationClip = "CharacterIdleUp";
			} else if (direction == Direction.Down) {
				animationClip = "CharacterIdleDown";
			}
		}

		animator.Play(animationClip);

		transform.Translate(movement * moveSpeed * Time.deltaTime);
	
	}
}
