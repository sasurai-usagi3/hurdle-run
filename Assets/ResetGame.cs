using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetGame : MonoBehaviour {
	public void OnClick() {
		Time.timeScale = 1f;
		SceneManager.LoadScene("main");
	}
}
