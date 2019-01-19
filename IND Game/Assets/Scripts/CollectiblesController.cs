using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SceneManagement;
using System;

public class CollectiblesController : MonoBehaviour 
{
	public CollectiblesData[] cd;
    //public HighScoreData[] Hs;
    private int[] ranking;
    public int DiamondScore;
    public int CubieScore;
    public int HexgonScore;
    public int TotalScore;
    private bool ScoreCalculated = false;
    private bool HSloaded = false;

    

	public void SaveData()
	{
        /*
		BinaryFormatter bf = new BinaryFormatter ();
		FileStream fs = File.Create (Application.persistentDataPath + "/Highscores.dat");
		bf.Serialize (fs, Hs);
		fs.Close ();
		Debug.Log ("Data saved.");
        */
	}



	public void LoadData()
	{
        /*
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
		*/
	}

   public void CalcHighScore()
    {
        //OutputCounts();

        DiamondScore = cd[0].CollectibleNum * 5;
        Debug.Log("Your score for diamonds is " + DiamondScore);

        CubieScore = cd[1].CollectibleNum * 3;
        Debug.Log("Your score for cubies is " + CubieScore);

        HexgonScore = cd[2].CollectibleNum * 1;
        Debug.Log("Your score for hexagons is " + HexgonScore);

        TotalScore = DiamondScore + CubieScore + HexgonScore;
        Debug.Log("Your total score is " + TotalScore);

        cd[3].CollectibleNum = TotalScore;

        

        //Array.Sort(Hs);
        




        //SaveData();





        /*Debug.Log(Hs[0].HighscoreNum);
        Debug.Log(Hs[1].HighscoreNum);
        Debug.Log(Hs[2].HighscoreNum);
        Debug.Log(Hs[3].HighscoreNum);
        Debug.Log(Hs[4].HighscoreNum);
        Debug.Log(Hs[5].HighscoreNum);*/


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
        if (go.name.Contains("Diamond"))
        {
            cd[0].CollectibleNum++;
        }
        else if (go.name.Contains("Cubie"))
        {
            cd[1].CollectibleNum++;
        }
        else if (go.name.Contains("Hexgon"))
        {
            cd[2].CollectibleNum++;
        }
        else if (go.name.Contains("Ankh"))
        {
            cd[6].CollectibleNum++;
        }

		//OutputCounts ();
			



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
		//CalcHighScore ();
        /*if (Input.GetKeyDown ("l")) {
			Debug.Log ("Loading data...");
			LoadData ();
		} else if (Input.GetKeyDown ("s")) 
		{
			Debug.Log ("Saving data...");
			SaveData ();
		}
        */

        if (SceneManager.GetActiveScene().buildIndex == 1 && ScoreCalculated == false)
        {
            CalcHighScore();
            ScoreCalculated = true;


        }
        




    }	
}
