using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

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

			if (name.Contains ("Diamond")) 
			{
				Timer.TimeLeft += 15;
			}

			if (name.Contains ("Cubie")) 
			{
				Timer.TimeLeft += 10;
			}

			if (name.Contains ("Hexgon")) 
			{
				Timer.TimeLeft += 5;
			}




            Destroy(gameObject);
        }


        
    }
}
