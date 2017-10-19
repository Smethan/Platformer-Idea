using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightScr : MonoBehaviour {
	public float duration = 0.5f;
	public float origRange;
	public Light lt;
	// Use this for initialization
	void Start () {
		lt = GetComponent<Light> ();
		origRange = lt.range;
	}
	
	// Update is called once per frame
	void Update () {
		float amplitude = Mathf.PingPong (Time.time, duration);
		amplitude = amplitude / duration * 0.2f + 0.5f;
		lt.range = origRange * amplitude + 4;
	}
}
