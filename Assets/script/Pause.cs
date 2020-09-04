using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public static bool GameIsPaused = false;
	
	public GameObject pauseMenuUI;
	public GameObject buttonLeft;
	public GameObject buttonRight;
	
	public void Paused(){
		pauseMenuUI.SetActive(true);
		Time.timeScale = 0f;
		GameIsPaused = true;
		buttonLeft.SetActive(false);
		buttonRight.SetActive(false);
	}
	
	public void Resume() {
		pauseMenuUI.SetActive(false);
		Time.timeScale = 1f;
		buttonLeft.SetActive(true);
		buttonRight.SetActive(true);
	}
	
	public void LoadMenu(){
		Application.LoadLevel("Menu");
	}
}
