using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

	public Ball ball;

	private Vector3 offset;

	void Start () 
	{
		offset = ball.transform.position - transform.position;
	}
	
	void Update () 
	{
		if (ball.transform.position.z <= 1829) {
			transform.position = ball.transform.position - offset;	
		}
	}
}
