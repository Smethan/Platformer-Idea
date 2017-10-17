using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionScript : MonoBehaviour {
	float speed = 20.0f;
	float useSpeed;
	float origX;
	// Use this for initialization
	void Start () {
		origX = transform.position.x;
	}
	void onTriggerEnter(Collider col) {
		if (col.tag == "WayPoint") {
			useSpeed = -speed;
		}

	}
	// Update is called once per frame
	void Update () {
		transform.Translate(useSpeed*Time.deltaTime,0,0);
	}
}
