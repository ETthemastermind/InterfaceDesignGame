using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverlapGem : MonoBehaviour {


	void OnTriggerEnter (Collider other)
	{
		Debug.Log ("Collided with environment");
		Destroy (gameObject);
	}


}
