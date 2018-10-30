using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SaveLoad : MonoBehaviour {

	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKeyDown ("space")) 
		{
			
			if (SceneManager.GetActiveScene ().buildIndex == 0) {
				SceneManager.LoadScene (1);
			} else
				SceneManager.LoadScene (0);
		}	
	}
}
