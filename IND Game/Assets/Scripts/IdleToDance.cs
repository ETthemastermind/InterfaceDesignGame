using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleToDance : MonoBehaviour {

    
	public GameObject Character;
	private Animator myAnim;

     
    
	// Use this for initialization
	void Start ()
    {

		myAnim = Character.GetComponent<Animator> (); //Get the animator component from the character
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Dance() //method to start the character dancing
    {
		myAnim.SetBool ("IsDancing", true); //sets the IsDancing variable in the animator to true
        
    }

    public void StopDance()
    {
		myAnim.SetBool ("IsDancing", false); //sets the IsDancing variable in the animator to false
        
    }
}
