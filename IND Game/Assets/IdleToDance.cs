using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToDance : MonoBehaviour {

    public bool CanDance = false;
     
    
	// Use this for initialization
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dance()
    {
        Debug.Log("Default Dance");
        
        CanDance = true;
        
    }

    public void StopDance()
    {
        Debug.Log("Game End");
        CanDance = false;
    }
}
