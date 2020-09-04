using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour {

	bool gameHasEnd = false;
	public float restartDelay = 1f;
	public GameObject completeLevelUI;
	public GameObject BackToMenuUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}

	public void endGame()
	{
		if (gameHasEnd == false) {
			gameHasEnd = true;
			Debug.Log ("GAME OVER");
			Invoke ("Restart", restartDelay);
		}
	}
	
	public void Pause()
	{
		BackToMenuUI.SetActive(true);
	}

	void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
}
}