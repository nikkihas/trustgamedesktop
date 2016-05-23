using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelAfterTime : MonoBehaviour {

	IEnumerator Start() {
		yield return new WaitForSeconds(46f);
		SceneManager.LoadScene("Level01");
	}
}