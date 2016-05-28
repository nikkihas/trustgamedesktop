// Modified by Rob on 27-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class IndicatorLight02 : MonoBehaviour {
	private bool changeColor = false;
	public Light indicatorLight;

	// Use this for initialization
	void Start() {
		indicatorLight = GetComponent<Light>();
		// Set the start color of the light
		indicatorLight.color = Color.green;
		// Start the coroutine
		StartCoroutine(randomInterval());
	}

	// Update is called once per frame
	void Update () {
		// Change the color of this indicator light based on the other indicator light
		if (GameObject.Find ("IndicatorLight01").GetComponent<IndicatorLight01> ().indicatorIsRed == true) {
			indicatorLight.color = Color.red;
			// Stop the coroutine
			StopAllCoroutines();
		} else {
			// Change the color of the indicator light based on a radom interval
			if (changeColor == true) {
				if (indicatorLight.color == Color.green) {
					indicatorLight.color = Color.red;
				} else {
					indicatorLight.color = Color.green;
				}
				// Reset the boolean
				changeColor = false;
				// Stop the coroutine
				StopAllCoroutines();
			}
		}
		// Restart the coroutine
		StartCoroutine(randomInterval());
	}

	// Generate a random interval
	IEnumerator randomInterval() {
		var interval = Random.Range (2.0F, 10.0F);
		yield return new WaitForSeconds(interval);
		changeColor = true;
	}
}