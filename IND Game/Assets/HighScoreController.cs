using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
using System;

public class HighScoreController : MonoBehaviour {

    public HighScoreData[] Hs;
    public CollectiblesController cc;

    // Use this for initialization

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        //prevent multiple instances of the same object
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }
    void Start ()
    {
        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();
        LoadData();
       
    }
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void LoadData()
    {
        
		if (File.Exists (Application.persistentDataPath + "/Highscores.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream fs = File.Open (Application.persistentDataPath + "/Highscores.dat", FileMode.Open);
			Hs = (HighScoreData[])bf.Deserialize (fs);
			fs.Close ();
			Debug.Log ("Data Loaded");
		} else 
		{
			Debug.LogError ("File you are trying to load from is missing");
		}
		
    }
}
