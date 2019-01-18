using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreController : MonoBehaviour {

    public HighScoreData[] Hs;
    public CollectiblesController cc;

    // Use this for initialization
    void Start ()
    {
        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();
       
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

   
}
