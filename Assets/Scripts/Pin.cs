using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {

	public float standingThreshold = 3f;

	public bool IsStanding ()
	{
		Vector3 rotationInEuler = transform.rotation.eulerAngles;
		float tiltX = (transform.eulerAngles.x < 90) ? transform.eulerAngles.x : 90 - transform.eulerAngles.x;
		float tiltZ = (transform.eulerAngles.z < 180f) ? transform.eulerAngles.z : 360 - transform.eulerAngles.z;

		return (tiltX < standingThreshold && tiltZ < standingThreshold);
	}

}
