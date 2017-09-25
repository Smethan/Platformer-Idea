using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxSpeed : MonoBehaviour {
	private Rigidbody rb;
	public float maxSpeed = 200f;//Replace with your max speed
	private float negMaxSpeed;
	void Start() {
		rb = GetComponent<Rigidbody>();
		negMaxSpeed = maxSpeed * -1;
	}
	void FixedUpdate()
	{
		if(rb.velocity.x > maxSpeed || rb.velocity.x < negMaxSpeed)
		{
			rb.velocity = new Vector3(rb.velocity.normalized.x * maxSpeed, rb.velocity.y, rb.velocity.z);
		}
	}
}
