using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		GameObject obj = GameObject.FindGameObjectWithTag ("hurdle");
		Instantiate (obj, new Vector3(0F, 0F, 0F), Quaternion.identity);
	}
}
