using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class TimeScript : MonoBehaviour {
	Text time;
	private FsmFloat Timefloat;
	// Use this for initialization
	void Start () {
		time = GetComponent<Text> ();
		Timefloat = FsmVariables.GlobalVariables.GetFsmFloat ("Time");
	}
	
	// Update is called once per frame
	void Update () {
		int TimeInt = (int)Timefloat.Value;
		time.text = "" + TimeInt;
	}
}
