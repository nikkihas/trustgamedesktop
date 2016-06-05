using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelAfterTime : MonoBehaviour {

	IEnumerator Start() {
		yield return new WaitForSeconds(50f);
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
	}
}