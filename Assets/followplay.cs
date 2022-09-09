
using UnityEngine;

public class followplay : MonoBehaviour {

	public Transform player;
	public Vector3 offset;//stores 3 floats
	// Update is called once per frame
	void Update () {
		//Debug.Log (player.position); to know player's position
		transform.position = player.position + offset;  // adding 2 vectors
	}
}
