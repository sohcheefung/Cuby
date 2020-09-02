using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Levelcomplete : MonoBehaviour {
	
	public void LoadNextLevel()
	{
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex + 1);
	}
}
