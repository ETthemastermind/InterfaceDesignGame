using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Surprise : MonoBehaviour {


    
 
	// Use this for initialization
	void Start ()
    {
        
        
        

    }
	
	// Update is called once per frame
	void Update ()
    {
        /*
        if (PopUpMenu.gameObject.activeInHierarchy == true)
        {
            Time.timeScale = 0;
        }
        if (PopUpMenu.gameObject.activeInHierarchy == false)
        {
            Time.timeScale = 1;
        }
        */
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            
        
        }
    }
}
