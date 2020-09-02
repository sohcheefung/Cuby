using UnityEngine;
using System.Collections;

public class playerCollision : MonoBehaviour {

	public playermove movement;

	void OnCollisionEnter (Collision collisionInfo)
	{
		if (collisionInfo.collider.tag == "Obstacle")
		{
			movement.enabled = false;
			FindObjectOfType<manager> ().endGame ();
	}	
}
}
