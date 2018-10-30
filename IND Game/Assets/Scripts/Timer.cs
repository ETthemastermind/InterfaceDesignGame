using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

	private float GameTimer = 30.0f;
	private bool GameEnded = false;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (GameTimer > 0 && GameEnded == false) 
		{
			GameTimer -= Time.deltaTime;
			//=-Debug.Log (GameTimer);


			if (GameTimer < 0) 
			{

				GameEnded = true;
				Debug.Log("Game Over");
				if (SceneManager.GetActiveScene ().buildIndex == 0) 
				{

					SceneManager.LoadScene (1);
				}


			}	
				
		}


	}
}
