using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class ScoreScript : MonoBehaviour {
	Text Score;
	private FsmInt _ScoreNum;
	// Use this for initialization
	void Start () {
		_ScoreNum = FsmVariables.GlobalVariables.GetFsmInt ("Score");
		Score = GetComponent<Text>();
	}

	// Update is called once per frame
	void Update () {
		int ScoreNum = _ScoreNum.Value;
		Debug.Log (Application.persistentDataPath);
		Score.text = "Score: " + ScoreNum;
	}
}
