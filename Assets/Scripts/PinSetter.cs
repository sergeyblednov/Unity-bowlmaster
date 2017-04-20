using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour {

	public Text standingText;
	public int lastStandingCount = -1;
	public GameObject pinSet;

	private Ball ball;
	private bool ballEnteredBox = false;
	private float lastChangeTime;

	void Start () 
	{
		ball = GameObject.FindObjectOfType<Ball> ();
	}

	void Update()
	{
		standingText.text = CountStanding ().ToString ();
		if (ballEnteredBox) {
			CheckStanding ();
		}
	}

	void CheckStanding ()
	{
		// Update the lastStandingCount 
		//Call PinsHaveSettled() when they have 
		int currentStanding = CountStanding ();

		if (currentStanding != lastStandingCount) {
			lastChangeTime = Time.time;
			lastStandingCount = currentStanding;
			return;
		}

		float settleTime = 3f;
		if ((Time.time - lastChangeTime) > settleTime) {
			PinsHaveSettled ();
		}
	}

	void PinsHaveSettled ()
	{
		ball.Reset ();
		lastStandingCount = -1;
		standingText.color = Color.green;
	}

	int CountStanding()
	{
		int count = 0;
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin> ()) {
			if (pin.IsStanding()) {
				count++;
			}
		}
		return count;
	}

	void OnTriggerEnter (Collider collider)
	{
		if (collider.gameObject.GetComponent<Ball>()) {
			ballEnteredBox = true;
			standingText.color = Color.red;
		}
	}

	void OnTriggerExit (Collider collider)
	{
		GameObject thing = collider.gameObject;
		if (thing.GetComponent<Pin>()) {
			Destroy (thing);
		}
	}

	#region Pins handling

	public void RaisePins ()
	{
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin> ()) {
			pin.RaiseIfStanding();
		}
	}

	public void LowerPins ()
	{
		foreach (Pin pin in GameObject.FindObjectsOfType<Pin> ()) {
			pin.Lower ();
		}
	}

	public void RenewPins ()
	{
		GameObject newPinSet = Instantiate (pinSet);
		newPinSet.transform.position += new Vector3 (0, 20, 0);
	}


	#endregion
}
