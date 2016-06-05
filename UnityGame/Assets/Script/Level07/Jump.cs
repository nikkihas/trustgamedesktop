// Created by Rob on 04-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {
	public Rigidbody playerCharacter;

	// Use this for initialization
	void Start() {
		playerCharacter = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update() {
		if (Input.GetButtonDown ("2")) {
			playerCharacter.velocity = new Vector3 (0, 8, 0);
		}
	}
}