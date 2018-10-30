using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemOverlapping : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Gem") 
		{
			//Debug.Log ("Gem Spawned in unreachable place");
			//Debug.Log (other.gameObject.name);
			Destroy(other.gameObject);

		}


	}
}
