using UnityEngine;
using System.Collections;

public class cloneBall1 : MonoBehaviour {

	public GameObject ball1;
	GameObject ball1clone;

	private float InstantiationTimer = 2f;

	void Update(){
		CreatePrefab();
		//ball1clone = Instantiate (ball1, transform.position, Quaternion.identity) as GameObject;
	}

	void CreatePrefab(){
		InstantiationTimer -= Time.deltaTime;
		if (InstantiationTimer <= 0)
		{
			Instantiate(ball1, transform.position, Quaternion.identity);
			InstantiationTimer = Random.Range(1f, 5f);
		}
	}


}
