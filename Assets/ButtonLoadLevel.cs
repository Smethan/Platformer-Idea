using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel : MonoBehaviour {

	public void ButtonLoadNextLevel() {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().buildIndex);
	}
	public void ButtonLoadOtherLevel() {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().buildIndex + 1);
	}
	public void ButtonLoadMainmenu() {
		SceneManager.LoadSceneAsync (0);
	}

	public void ButtonQuit() {
		Application.Quit ();
	}
}
