﻿using UnityEngine;
using System.Collections;

public class Move1 : MonoBehaviour {
	
	private Vector3 pos1 = new Vector3(7,1,-11);
	private Vector3 pos2 = new Vector3(-5,1,-11);
	public float speed = 1.0f;

	void Update() {
		transform.position = Vector3.Lerp (pos1, pos2, (Mathf.Sin(speed * Time.time) + 1.0f) / 2.0f);
	}
}