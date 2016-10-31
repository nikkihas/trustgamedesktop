// Modified and checked by Rob on 31-10-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DoorController : MonoBehaviour {
	private float currentTimesPressed = 0;
	public static float timesPressed = 0;
	public static bool openDoor = false;
	private float threshold;
	public AudioSource rightSound;
	public AudioSource wrongSound;

	// Use this for initialization
	void Start () {
		// Generate a random threshold
		threshold = Random.Range (2, 6);
	}
	
	// Update is called once per frame
	void Update () {
		// Open the door when the button is pressed within the threshold
		if (timesPressed <= threshold && timesPressed != currentTimesPressed) {
			// Set the boolean
			openDoor = true;
			// Set the float
			currentTimesPressed = timesPressed;
			// Play a sound
			rightSound.Play();
		}
		// Close the door when the button is pressed beyond the threshold
		if (timesPressed > threshold) {
			// Reset the floats
			currentTimesPressed = 0;
			timesPressed = 0;
			// Generate a new threshold
			threshold = Random.Range (2, 6);
			// Play a sound
			wrongSound.Play();
		}
	}
}