using UnityEngine;
using System.Collections;

public class playermove : MonoBehaviour {
	// reference to the rigidbody component 'r'
	public Rigidbody r;

	public float forwardForce = 2000f;
	public float sidewaysForce = 500f;
	
	// marked this as 'fixedupdate' because we
	// are using it to mess with physics
	void FixedUpdate () 
	{
		r.AddForce (0, 0, forwardForce * Time.deltaTime);

		if(Input.GetKey("d"))
		{
			r.AddForce (sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if(Input.GetKey("a"))
		{
			r.AddForce (-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);	
		}
		if(r.position.y < -1f)
		{
			FindObjectOfType<manager> ().endGame ();
	}
}
}
