using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PopUpMenuController : MonoBehaviour {

    
    public int PickRndNum;
    public CollectiblesController cc;
    public Canvas GoodAnkh;
    public Canvas BadAnkh;

    // Use this for initialization
    void Start ()
    {
        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();
    }
	
	// Update is called once per framebb]
	void Update () {
		
	}

    public void RestartTime()
    {
        Time.timeScale = 1;

    }


    public void PickUp()
    {
        System.Random rand = new System.Random();
        PickRndNum = rand.Next(1, 3);

        if (PickRndNum == 1)
        {

            Debug.Log("Points Gained");
            cc.cd[3].CollectibleNum = cc.cd[3].CollectibleNum + 20;
            Debug.Log(cc.cd[3].CollectibleNum);
            GoodAnkh.GetComponent<Canvas>().enabled = true;
            Debug.Log("Image enabled");
        }

        if (PickRndNum == 2)
        {

            Debug.Log("Points Lost");
            cc.cd[3].CollectibleNum = cc.cd[3].CollectibleNum - 20;
            Debug.Log(cc.cd[3].CollectibleNum);
            BadAnkh.GetComponent<Canvas>().enabled = true;
            Debug.Log("Image enabled");



        }



    }



}
