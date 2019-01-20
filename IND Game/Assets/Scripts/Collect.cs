using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collect : MonoBehaviour {

    private AudioSource Source;
    [SerializeField] private AudioClip Clip;

	public CollectiblesController cc;







	void Start()
	{
		GameObject ccgo = GameObject.Find ("CollectiblesController");
		cc = ccgo.GetComponent<CollectiblesController> ();
	}

	void Update()
	{
        transform.position = new Vector3(transform.position.x, 2.5f, transform.position.z);

	}


    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {

            Source = other.GetComponent<AudioSource>();
            Source.PlayOneShot(Clip, 1.0f);


			//cc.IncrementCount(gameObject);

			if (name.Contains ("Diamond")) 
			{
				Timer.TimeLeft += 5;
                cc.cd[0].CollectibleNum ++;
                cc.cd[3].CollectibleNum += 5;



			}

			if (name.Contains ("Cubie")) 
			{
				Timer.TimeLeft += 4;
                cc.cd[0].CollectibleNum ++;
                cc.cd[3].CollectibleNum += 3;


            }

			if (name.Contains ("Hexgon")) 
			{
				Timer.TimeLeft += 3;
                cc.cd[0].CollectibleNum ++;
                cc.cd[3].CollectibleNum += 1;


            }

            if (name.Contains("Ankh"))
            {
                cc.cd[6].CollectibleNum++;

            }


            Debug.Log("PickUp");

            Destroy(gameObject);
        }


        
    }
}
