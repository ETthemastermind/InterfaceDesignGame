using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	private int XRndNum;
	private int ZRndNum;
	private float TimeToSpawn;
	private int RndNumCounter = 0;
	public GameObject Collectible;
	//public Vector3 Spawnpoint;
	//private Quaternion SpawnRotation;
	private bool ObjectSpawned = false;

	// Use this for initialization
	void Start () 
	{
		Debug.Log ("test");

	}
	
	// Update is called once per frame
	void Update () 
	{

		// y = 2.5
		// range of z = 70 & -125
		//range of x = 80 & -80
		while (ObjectSpawned == false) //checks to see if an object has been spawned yet (for debugging purposes)
		{
			ObjectSpawned = true; //turns the objectspawned to true (for debugging purposes)

			System.Random rand = new System.Random (); //creates a new thingy for making random numbers

			TimeToSpawn = rand.Next (1, 30); //creates a random number between 1 and 30
			Debug.Log (TimeToSpawn);

			while (TimeToSpawn != 0) //checks to see if the time to spawn is 0
			{
				TimeToSpawn -= Time.deltaTime; //my understanding is that this should take away from the time to spawn every second of play and hold this loop going while the time to spawn is not 0
				Debug.Log (TimeToSpawn);
			}

			Debug.Log ("Ready to Spawn");

			XRndNum = rand.Next (-80, 80); //generates a random x coord 
			ZRndNum = rand.Next (-125, 70); //generates a random z coord

			Vector3 Spawnpoint = new Vector3 (XRndNum, 2.5f, ZRndNum); //creates the spawn vector for the object to be instantiated

			//Debug.Log (Spawnpoint);

			Instantiate (Collectible, Spawnpoint, transform.rotation); //instantiates the object

          

			ObjectSpawned = false; //for debugging purposes so that only 1 spawns


		}

		//System.Random rand = new System.Random ();     ignore this section, it was just experimentation
		//RndNum = rand.Next (1, 10);
		//while (RndNum != RndNumCounter) 
		//{
		//	RndNumCounter = RndNumCounter + 1;
		//}
		//
		//if (RndNum == RndNumCounter) 
		//{
		//	Debug.Log ("Object Spawned");
		//}

	}
}
