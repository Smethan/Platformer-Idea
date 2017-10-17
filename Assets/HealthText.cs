using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using HutongGames.PlayMaker;

public class HealthText : MonoBehaviour {
	Text Health;
	private FsmFloat _HealthFloat;
	// Use this for initialization
	void Start () {
		_HealthFloat = FsmVariables.GlobalVariables.GetFsmFloat ("Health");
		Health = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		int HealthFloat = (int) _HealthFloat.Value;
		Health.text = "Health: " + HealthFloat;
	}
}
