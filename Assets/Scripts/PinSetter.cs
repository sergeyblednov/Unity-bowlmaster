using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PinSetter : MonoBehaviour {

	public Text standingText;

	private bool ballEnteredBox = false;

	void Update()
	{
		standingText.text = CountStanding ().ToString();
	}

	int CountStanding()
	{
		int count = 0;
		Pin[] pins = GameObject.FindObjectsOfType<Pin> ();
		foreach (Pin pin in pins) {
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
		if (collider.gameObject.GetComponent<Pin>()) {
			Destroy (collider.gameObject);
		}
	}
}
