using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopTime : MonoBehaviour {
    public GameObject PopUp;

    // Use this for initialization
    void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
        if (PopUp.GetComponentInChildren<Canvas>().enabled == true)
        {
            Time.timeScale = 0;
        }
        else if(PopUp.GetComponentInChildren<Canvas>().enabled == false)
        {
            Time.timeScale = 1;
        }




    }
}
