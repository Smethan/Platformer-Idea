using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonLoadLevel : MonoBehaviour {

	public void ButtonLoadNextLevel(int Level) {
		SceneManager.LoadSceneAsync (Level);
	}

	public void ButtonQuit() {
		Application.Quit ();
	}
}
