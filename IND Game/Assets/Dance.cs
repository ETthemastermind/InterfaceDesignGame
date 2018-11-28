using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dance : MonoBehaviour {

    Animator myAnim;
    public Texture CharacterButton;


    // Use this for initialization
    void Start ()
    {
        myAnim = GetComponent<Animator>();
        CharacterButton = GetComponent<Texture>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (GameObject.Find("CharacterPortrait").GetComponent<IdleToDance>().CanDance == true)
        {
            Debug.Log("Character Should Be Dancing");
            myAnim.SetBool("IsDancing", true);
        }

        else
        {
            myAnim.SetBool("IsDancing", false);
        }
	}
}



//GameObject.Find("CharacterPortrait").GetComponent<IdleToDance>().CanDance == true
//CharacterButton.GetComponent<IdleToDance>().CanDance == true
