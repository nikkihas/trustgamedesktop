// Created by Rob on 04-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class IndicatorLight : MonoBehaviour {
	private bool changeColor = false;
	public bool indicatorIsRed = false;
	public Light indicatorLight;
	public Color colorGreen = Color.green;
	public Color colorRed = Color.red;

	// Use this for initialization
	void Start() {
		indicatorLight = GetComponent<Light>();
		// Set the start color of the light
		indicatorLight.color = colorGreen;
		// Start the coroutine
		StartCoroutine(randomInterval());
	}

	// Update is called once per frame
	void Update () {
		// Change the color of the indicator light based on a radom interval
		if (changeColor == true) {
			if (indicatorLight.color == colorGreen) {
				indicatorLight.color = colorRed;
				indicatorIsRed = true;
			} else {
				indicatorLight.color = colorGreen;
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
		var interval = Random.Range (2.0F, 34.0F);
		yield return new WaitForSeconds(interval);
		changeColor = true;
		print(interval);
	}
}