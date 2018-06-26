using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour {
	bool isJumping;

	// Use this for initialization
	void Start () {
		isJumping = false;
	}
	
	// Update is called once per frame
	void Update () {
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();

		if (Input.GetKey(KeyCode.Space) && !isJumping) {
			rigidbody.velocity += Vector2.up * 1F;
			isJumping = true;
		}

		if (transform.position.y <= 0) {
			isJumping = false;
		}
	}
}
