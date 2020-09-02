using UnityEngine;
using System.Collections;

public class endTrigger : MonoBehaviour {

	public manager gameManager;

	void OnTriggerEnter (){
		gameManager.CompleteLevel();
	}
}