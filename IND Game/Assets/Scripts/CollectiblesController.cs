using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class CollectiblesController : MonoBehaviour 
{
	public CollectiblesData[] cd;

	public void SaveData()
	{
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream fs = File.Create (Application.persistentDataPath + "/gameData.dat");
		bf.Serialize (fs, cd);
		fs.Close ();
		Debug.Log ("Data saved.");
	}



	public void LoadData()
	{
		if (File.Exists (Application.persistentDataPath + "/gameData.dat")) {
			BinaryFormatter bf = new BinaryFormatter ();
			FileStream fs = File.Open (Application.persistentDataPath + "/gameData.dat", FileMode.Open);
			cd = (CollectiblesData[])bf.Deserialize (fs);
			fs.Close ();
			Debug.Log ("Data Loaded");
		} else 
		{
			Debug.LogError ("File you are trying to load from is missing");
		}
			
	}


	void Awake()
	{
		DontDestroyOnLoad (gameObject);

		if (FindObjectsOfType (GetType ()).Length > 1) 
		{ 
			Destroy (gameObject);
		}	
	}

	public void IncrementCount (GameObject go)
	{
		if (go.name.Contains ("Diamond")) {
			cd [0].CollectibleNum++;
		} 
		else if (go.name.Contains ("Cubie")) {
			cd [1].CollectibleNum++;
		} 
		else if (go.name.Contains ("Hexgon")) {
			cd [2].CollectibleNum++;
		}

		OutputCounts ();
			



	}

	void OutputCounts()
	{
		//debug
		Debug.Log("You Have Collected: ");
		Debug.Log ("Diamond = " + cd [0].CollectibleNum);
		Debug.Log ("Cubie = " + cd [1].CollectibleNum);
		Debug.Log ("Hexagon = " + cd [2].CollectibleNum);
	}

	void Update()
	{
		if (Input.GetKeyDown ("l")) {
			Debug.Log ("Loading data...");
			LoadData ();
		} else if (Input.GetKeyDown ("s")) 
		{
			Debug.Log ("Saving data...");
			SaveData ();
		}
	}	
}
