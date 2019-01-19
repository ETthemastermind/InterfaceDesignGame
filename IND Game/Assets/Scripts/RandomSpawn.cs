using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	private int XRndNum;
	private int ZRndNum;
	private float TimeToSpawn;

	public GameObject Diamond;
	public int MaxDiamonds;
	private int CurrentDiamonds;

	public GameObject Cubie;
	public int MaxCubies;
	private int CurrentCubies;

	public GameObject Hexagon;
	public int MaxHexagons;
	private int CurrentHexagons;

    public GameObject Ankh;
    public int MaxAnkh;
    private int CurrentAnkh;

	//5d 15c 25h


	// Use this for initialization
	void Start () 
	{
		System.Random rand = new System.Random (); //creates a new thingy for making random numbers
		TimeToSpawn = rand.Next (1, 10); //creates a random number between 1 and 10
		//Debug.Log("Initial time to spawn is " + TimeToSpawn);

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (TimeToSpawn <= 0) 
		{
			//Debug.Log ("Item ready to spawn");
			// y = 2.5
			// range of z = 70 & -125
			//range of x = 80 & -80
			System.Random rand = new System.Random ();

			XRndNum = rand.Next (-80, 80); //generates a random x coord 
			ZRndNum = rand.Next (-125, 70); //generates a random z coord

			Vector3 Spawnpoint = new Vector3 (XRndNum, 2.5f, ZRndNum); //creates the spawn vector for the object to be instantiated
			//Debug.Log(Spawnpoint);


			int NumToPick = rand.Next (0,101 );
			//Debug.Log ("Randomly genned number is " + NumToPick);

			if (NumToPick > 0 && NumToPick < 50 && CurrentHexagons != MaxHexagons) {
				Instantiate (Hexagon, Spawnpoint, Quaternion.Euler(new Vector3(270,0,0))); //instantiates the object
				//Debug.Log ("Hexagon Spawned");
				CurrentHexagons += 1;
			} 




			if (NumToPick > 50 && NumToPick < 81 && CurrentCubies != MaxCubies) {
				Instantiate (Cubie, Spawnpoint, Quaternion.Euler(new Vector3(270, 0, 0))); //instantiates the object
				//Debug.Log ("Cubie Spawned");
				CurrentCubies += 1;
			} 

			if (NumToPick > 80 && NumToPick < 96 && CurrentDiamonds != MaxDiamonds) {
				Instantiate (Diamond, Spawnpoint, Quaternion.Euler(new Vector3(270, 0, 0))); //instantiates the object
				//Debug.Log ("Diamond Spawned");
				CurrentDiamonds += 1;
			}

            if (NumToPick > 95 && NumToPick < 101 && CurrentAnkh != MaxAnkh)
            {
                Instantiate(Ankh, Spawnpoint, Quaternion.Euler(new Vector3(0, 0, 0))); //instantiates the object
                                                                                            //Debug.Log ("Diamond Spawned");
                CurrentAnkh += 1;
            }







            //CurrentNumberSpawned += 1;



            TimeToSpawn = rand.Next (1, 10);
			//Debug.Log ("New time to spawn is " + TimeToSpawn);




		}


		TimeToSpawn -= Time.deltaTime;





	}
}
