using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelTime : MonoBehaviour {

	public float delay = 1.0F;

		IEnumerator Start () {
			yield return new WaitForSeconds (delay);
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
			// Reset the game time
			GameTimer.timeLeft = 720.0F;
			// Start the game timer
			GameTimer.timerStarted = true;
		}
	}