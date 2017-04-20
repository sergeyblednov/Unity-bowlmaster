using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	public float standingThreshold = 7f;
	public float distanceToRaise;

	private Rigidbody rigidBody;
//	private bool isRaised = false;

	void Start() 
	{
		rigidBody = GetComponent<Rigidbody> ();
	}

	public bool IsStanding ()
	{
		Vector3 rotationInEuler = transform.rotation.eulerAngles;
		float tiltX = (transform.eulerAngles.x < 90) ? transform.eulerAngles.x : 90 - transform.eulerAngles.x;
		float tiltZ = (transform.eulerAngles.z < 180f) ? transform.eulerAngles.z : 360 - transform.eulerAngles.z;

		return (tiltX < standingThreshold && tiltZ < standingThreshold);
	}

	public void RaiseIfStanding ()
	{
		if (IsStanding()) {
//			isRaised = true;
			rigidBody.useGravity = false;
			transform.Translate (new Vector3 (0, distanceToRaise, 0), Space.World);
		}
	}

	public void Lower ()
	{
//		if (isRaised) {
			transform.Translate (new Vector3 (0, -distanceToRaise, 0), Space.World);
			rigidBody.useGravity = true;
//			isRaised = false;
//		}
	}

}
