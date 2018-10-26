using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour {

    private AudioSource Source;
    [SerializeField] private AudioClip Clip;

	CollectiblesController cc;

	void Start()
	{
		GameObject ccgo = GameObject.Find ("CollectiblesController");
		cc = ccgo.GetComponent<CollectiblesController> ();
	}


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            Source = other.GetComponent<AudioSource>();
            Source.PlayOneShot(Clip, 1.0f);


			cc.IncrementCount(gameObject);


            Destroy(gameObject);
        }


        
    }
}
