// Modified by Rob on 15-06-2016, please do not edit

using UnityEngine;
using System.Collections;

public class RespawnTimer : MonoBehaviour {
	public static float time = 0;
	public int triggerAmount = 3;

	// Update is called once per frame
	public void Update() {
		// Start a timer after Charlie has been respawned for a specific amount of times
		if (RigidbodyController.timesRespawned >= triggerAmount) {
			time += Time.deltaTime;
		}
	}
}