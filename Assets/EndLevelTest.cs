using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTest : MonoBehaviour {
	public GameObject go;
	public Object[] gos; 
	void Start(){
		go = Resources.Load("LoadScreen") as GameObject;
		gos = GameObject.FindGameObjectsWithTag("Health");
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Destroy (gos[0]);
			Destroy (other.gameObject);
			Instantiate (go);
	}
}
}
