// Edited by Nikki Hes on 29-06-16

using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class NextLevelTime : MonoBehaviour {

	public float delay = 49.0F;

		IEnumerator Start () {
			yield return new WaitForSeconds (delay);

			// Reset the game time
			GameTimer.timeLeft = 960.0F;
			// Start the game timer
			GameTimer.timerStarted = true;

			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);

		}
	}