using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using HutongGames.PlayMaker;
using System;
using System.Collections.Generic;

public class ButtonLoadLevel : MonoBehaviour {
	public int ResetCount = 0;
	public int ScoreDat;
	public int[] DataSet;
	public int[] oldScore;
	public GameObject go;

	void Start() {
		go = Resources.Load("LoadScreen") as GameObject;
		DataSet = new int[2];
		oldScore = new int[2];
		ScoreDat = FsmVariables.GlobalVariables.GetFsmInt ("Score").Value;
		oldScore = SaveLoadManager.Load ();
		DataSet [0] = ScoreDat;
		DataSet [1] = ResetCount;
		if (ScoreDat > oldScore[0]) {
			SaveLoadManager.SaveData (DataSet);
		} else {
			return;
		}
	}
	public void ButtonLoadNextLevel() {
		SceneManager.LoadSceneAsync (SceneManager.GetActiveScene().buildIndex);
	}
	public void ButtonLoadOtherLevel() {
		Instantiate (go);
	}
	public void ButtonLoadMainmenu() {
		SceneManager.LoadSceneAsync (0);
	}
	public void ResetButton() {
		ResetCount = ResetCount + 1;
		DataSet [0] = 1;
		DataSet [1] = ResetCount;
		SaveLoadManager.SaveData (DataSet);
		SceneManager.LoadSceneAsync (0);
	}

	public void ButtonQuit() {
		Application.Quit ();
	}
}
