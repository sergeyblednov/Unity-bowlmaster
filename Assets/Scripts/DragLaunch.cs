using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent (typeof(Ball))]
public class DragLaunch : MonoBehaviour {

	private Ball ball;
	private float startTime;
	private float endTime;
	private Vector3 dragStartPosition;
	private Vector3 dragEndPosition;

	void Start () 
	{
		ball = GetComponent<Ball> ();
	}

	public void DragStart()
	{
		startTime = Time.time;
		dragStartPosition = Input.mousePosition;
		print ("DragStart" + dragStartPosition);
	}

	public void DragEnd ()
	{
		endTime = Time.time;
		dragEndPosition = Input.mousePosition;

		float dragDuration = endTime - startTime;
		float launchSpeedX = (dragEndPosition.x - dragStartPosition.x) / dragDuration;
		float launchSpeedZ = (dragEndPosition.y - dragStartPosition.y) / dragDuration;
		Vector3 launchVlelocity = new Vector3 (launchSpeedX, 0, launchSpeedZ);
		ball.Launch (launchVlelocity);
		print ("DragEnd" + dragEndPosition);
	}
}
