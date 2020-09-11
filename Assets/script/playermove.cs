using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class playermove : MonoBehaviour {
	// reference to the rigidbody component 'r'
	public Rigidbody r;
	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	bool movingLeft;
	bool movingRight;
	
	// marked this as 'fixedupdate' because we
	// are using it to mess with physics
	void FixedUpdate () 
	{
		r.AddForce (0, 0, forwardForce * Time.deltaTime);

		
		if(movingLeft)
		{
			Debug.Log("Moving to left...");
			r.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if(movingRight)
		{
			Debug.Log("Moving to right...");
			r.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		
		if(r.position.y < -1f)
		{
			FindObjectOfType<manager> ().endGame ();
	}
}

	public void moveLeftOn(){
		movingLeft = true;
	}
	
	public void moveLeftOff(){
		movingLeft = false;
	}

	public void moveRightOn(){
		movingRight = true;
	}
	
	public void moveRightOff(){
		movingRight = false;
	}

	
}
