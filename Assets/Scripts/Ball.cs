﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector3 launchDirection;
	public bool inPlay = false;

	private AudioSource audioSource;
	private Rigidbody rigidBody;
	private Vector3 startPosition;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody> ();
		rigidBody.useGravity = false;
		startPosition = transform.position;
	}

	public void Launch (Vector3 velocity)
	{
		inPlay = true;
		rigidBody.useGravity = true;
		rigidBody.velocity  = velocity;

		audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}

	public void Reset ()
	{
		Debug.Log ("Resetting the ball");
		inPlay = false;
		transform.position = startPosition;
		rigidBody.velocity = Vector3.zero;
		rigidBody.angularVelocity = Vector3.zero;
		rigidBody.useGravity = false;
	}
}