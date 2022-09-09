
using UnityEngine;

public class collision : MonoBehaviour {

	public playermove move;

	void OnCollisionEnter(Collision colinfo){
		if (colinfo.collider.tag=="obsticle"){ //.name can be used to name the colliding object but naming everything is a pain so tag hepls grouping them
			move.enabled = false;
		}
	}
}
