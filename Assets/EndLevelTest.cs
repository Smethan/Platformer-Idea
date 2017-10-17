﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelTest : MonoBehaviour {
	GameObject[] gos;
	void Start(){
		gos = GameObject.FindGameObjectsWithTag("Fire");
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			if (SceneManager.GetActiveScene ().buildIndex + 1 < SceneManager.sceneCountInBuildSettings) {
				SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			
			} else {
				SceneManager.LoadScene (0);
			}
	}
}
}
