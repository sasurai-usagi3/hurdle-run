using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Character : MonoBehaviour {
	bool isJumping;
	Rigidbody2D rigidbody;

	// Use this for initialization
	void Start () {
		isJumping = false;
		rigidbody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Space) && !isJumping) {
			rigidbody.velocity += Vector2.up * 6F;
			isJumping = true;
		}

		if (rigidbody.velocity.y == 0) {
			isJumping = false;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag ("hurdle")) {
			SceneManager.LoadScene("main");
		}
	}
}
