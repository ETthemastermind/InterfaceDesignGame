using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class places : MonoBehaviour {
	private AudioSource Source;
	[SerializeField] private AudioClip clip;

    public Toggle HasVisited;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "Player") {

			Source = other.GetComponent<AudioSource> ();
			Source.PlayOneShot (clip, 1.0f);


			Debug.Log ("Sound Played");



			Debug.Log ("Collision Detected, collided with" + gameObject.name);
			Destroy (gameObject);

            HasVisited.GetComponent<Toggle>().isOn = true;

		}	
	}	
}
