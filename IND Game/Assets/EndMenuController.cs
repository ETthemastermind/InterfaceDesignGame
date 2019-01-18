using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class EndMenuController : MonoBehaviour {

	public CollectiblesController cc;
    public HighScoreController Hs;
	public Text PlayerName;
    public Text DiamondScore;
    public Text CubieScore;
    public Text HexagonScore;
    public Text AnkhScore;
    public Text Steps;
    public Text TimeTaken;


    public Text Hs1;
    public Text Hs2;
    public Text Hs3;
    public Text Hs4;
    public Text Hs5;

    public List<int> TempHS = new List<int>();

    // Use this for initialization
    void Start ()
	{
		GameObject ccgo = GameObject.Find ("CollectiblesController");
		cc = ccgo.GetComponent<CollectiblesController> ();

        GameObject Hsgo = GameObject.Find("HighScoreController");
        Hs = Hsgo.GetComponent<HighScoreController>();


        AssignHighScore();
        SortHighScore();
        AssignData();


    }
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	public void QuitGame()
	{

		SceneManager.LoadScene (1);

	}

	public void Restart()
	{
		SceneManager.LoadScene (0);
	}

	public void AssignData()
	{
		PlayerName.text = MainMenuController.ApprovedPlayerName + " - " + cc.cd[3].CollectibleNum;
        DiamondScore.text = cc.cd [0].CollectibleNum.ToString ();
        CubieScore.text = cc.cd[1].CollectibleNum.ToString();
        HexagonScore.text = cc.cd[2].CollectibleNum.ToString();
        AnkhScore.text = cc.cd[6].CollectibleNum.ToString();
        Steps.text = cc.cd[4].CollectibleNum.ToString();
        TimeTaken.text = cc.cd[5].CollectibleName.ToString();

        Hs1.text = Hs.Hs[0].HighscoreName + "-" + Hs.Hs[0].HighscoreNum;
        Hs2.text = Hs.Hs[1].HighscoreName + "-" + Hs.Hs[1].HighscoreNum;
        Hs3.text = Hs.Hs[2].HighscoreName + "-" + Hs.Hs[2].HighscoreNum;
        Hs4.text = Hs.Hs[3].HighscoreName + "-" + Hs.Hs[3].HighscoreNum;
        Hs5.text = Hs.Hs[4].HighscoreName + "-" + Hs.Hs[4].HighscoreNum;


    }

    public void AssignHighScore()
    {
        Hs.Hs[5].HighscoreNum = cc.cd[3].CollectibleNum;
        Hs.Hs[5].HighscoreName = MainMenuController.ApprovedPlayerName;
    }


    public void SortHighScore()
    {
        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            TempHS.Add(Hs.Hs[i].HighscoreNum);
            //Debug.Log("Unsorted" + TempHS[i]);
        }
        TempHS.Sort();
        TempHS.Reverse();

        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            Hs.Hs[i].HighscoreNum = TempHS[i];
        }
        
       
    }




}
