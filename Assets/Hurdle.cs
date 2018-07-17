using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hurdle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
		rigidbody.velocity += Vector2.left * 3;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x <= -5) {
			Destroy (gameObject);
		}
	}
}
