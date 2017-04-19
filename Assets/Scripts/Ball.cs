using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public Vector3 launchDirection;
	public bool inPlay = false;

	private AudioSource audioSource;
	private Rigidbody rigidBody;

	void Start () 
	{
		rigidBody = GetComponent<Rigidbody> ();
		rigidBody.useGravity = false;
//		Launch(launchDirection);
	}

	public void Launch (Vector3 velocity)
	{
		inPlay = true;
		rigidBody.useGravity = true;
		rigidBody.velocity  = velocity;

		audioSource = GetComponent<AudioSource> ();
		audioSource.Play ();
	}
}