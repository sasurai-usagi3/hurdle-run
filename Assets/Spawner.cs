using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
	int counter, goal;

	// Use this for initialization
	void Start () {
		counter = 0;
		goal = Random.Range(10, 200);
	}
	
	// Update is called once per frame
	void Update () {
		if (counter >= goal) {
			GameObject obj = GameObject.FindGameObjectWithTag ("hurdle");
			Instantiate (obj, transform.position, Quaternion.identity);
			counter = 0;
			goal = Random.Range(10, 200);
		}
		++counter;
	}
}
