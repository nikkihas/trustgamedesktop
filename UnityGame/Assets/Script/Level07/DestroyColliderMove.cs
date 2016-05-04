// Created by Rob on 04-05-2016, please do not edit

using UnityEngine;
using System.Collections;

public class DestroyColliderMove : MonoBehaviour {
	public MeshCollider meshCollider;

	// Use this for initialization
	void Start () {
		meshCollider = GetComponent<MeshCollider> ();
	}

	// Update is called once per frame
	void Update () {
		// Destroy the mesh collider when the player moves while it not allowed
		if (GameObject.Find("IndicatorLight").GetComponent<IndicatorLight>().indicatorIsRed == true && Input.anyKey == true) {
			Destroy (meshCollider);
		}
	}
}