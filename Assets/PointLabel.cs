using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointLabel : MonoBehaviour {
	private float point; 
	private Text textComponent;

	// Use this for initialization
	void Start () {
		point = 0;
		textComponent = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		point += 0.1F;
		if (Mathf.Approximately (Time.timeScale, 0F)) {
			return;
		}
		textComponent.text = string.Format("Point: {0}", Mathf.Floor(point));
	}
}
