using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;
using System;
using System.Collections.Generic;

public class HighScoreGet : MonoBehaviour {
	Text HighScore;
	public int[] LoadedScore;
	// Use this for initialization
	void Start () {
		LoadedScore = new int[2];
		HighScore = GetComponent<Text> ();
		LoadedScore = SaveLoadManager.Load ();
	}
	
	// Update is called once per frame
	void Update () {
		if (LoadedScore [0] > 0) {
			HighScore.text = "Highscore: " + LoadedScore [0];
		} else {
			HighScore.text = "HighScore: 0";
		}
	}
}
