using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	public float launchSpeed;

	private AudioSource audioSource;
	private Rigidbody rigidBody;

	void Start () 
	{
		audioSource = GetComponent<AudioSource> ();
		rigidBody = GetComponent<Rigidbody> ();
		Launch();
	}

	public void Launch ()
	{
		rigidBody.velocity  = new Vector3 (0, 0, launchSpeed);
		audioSource.Play ();
	}
}