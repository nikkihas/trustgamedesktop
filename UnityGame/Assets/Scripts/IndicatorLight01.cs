// Modified by Rob on 27-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class IndicatorLight01 : MonoBehaviour {
	private bool changeColor = false;
	public bool indicatorIsRed = false;
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
		// Change the color of the indicator light based on a radom interval
		if (changeColor == true) {
			if (indicatorLight.color == Color.green) {
				indicatorLight.color = Color.red;
				indicatorIsRed = true;
			} else {
				indicatorLight.color = Color.green;
				indicatorIsRed = false;
			}
			// Reset the boolean
			changeColor = false;
			// Stop the coroutine
			StopAllCoroutines();
		}
		// Restart the coroutine
		StartCoroutine(randomInterval());
	}

	// Generate a random interval
	IEnumerator randomInterval() {
		var interval = Random.Range (5.0F, 20.0F);
		yield return new WaitForSeconds(interval);
		changeColor = true;
	}
}