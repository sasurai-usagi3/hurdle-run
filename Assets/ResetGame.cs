using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {
	public void OnClick() {
		SceneManager.LoadScene("main");
	}
}
