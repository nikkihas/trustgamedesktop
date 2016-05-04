// Created by Rob on 04-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyColliderJump : MonoBehaviour {
	private float timesJumped;
	public MeshCollider meshCollider;

	// Use this for initialization
	void Start () {
		meshCollider = GetComponent<MeshCollider> ();
	}
	
	// Update is called once per frame
	void Update () {
		// Destroy the mesh collider when the player jumps more than 3 times
		if (Input.GetButtonDown ("Jump")) {
			timesJumped++;
		}
		if (timesJumped > 3) {
			Destroy (meshCollider);
		}
	}
}