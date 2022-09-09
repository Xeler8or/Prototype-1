using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermove : MonoBehaviour {

	public Rigidbody rb;
	public float forwardforce = 750f;
	public float sideforce = 100f;
	// Use this for initialization
	/*void Start () {
		Debug.Log("GAME STARTING");
		rb.AddForce (0, 200, 500);
	}*/
	
	// Update is called once per frame
	void FixedUpdate () {  //fixed is better for physics
		rb.AddForce (0, 0, forwardforce*Time.deltaTime); // delta time is amt of seconds before last frame because diff machines will have diff fps
		if (Input.GetKey("d")){        // there is a better way to accept keys but this is cool for learning purpose
			rb.AddForce(sideforce*Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
		}
		if (Input.GetKey("a")){
			rb.AddForce(-sideforce*Time.deltaTime , 0 , 0 , ForceMode.VelocityChange);
		}
	}
}
