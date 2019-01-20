using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



public class EndMenuController : MonoBehaviour
{

    public CollectiblesController cc;
    public HighScoreController Hs;
    public HighScoreData tempNum;
    public HighScoreData tempName;
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

    public List<string> TempHs = new List<string>();



    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        //prevent multiple instances of the same object
        if (FindObjectsOfType(GetType()).Length > 1)
        {
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        GameObject ccgo = GameObject.Find("CollectiblesController"); //find the collectibles controller object
        cc = ccgo.GetComponent<CollectiblesController>();

        GameObject Hsgo = GameObject.Find("HighScoreController"); //find the highscore controller object
        Hs = Hsgo.GetComponent<HighScoreController>();


        AssignHighScore(); //runs the method to add the players score and name to the high score array
        SortHighScore(); // sorts the highscores from highest to lowest
        AssignData(); // assigns data from the cd array their respective GUI elements
        SaveData(); //saves the highscores to an external file

        //Debug.Log(Application.persistentDataPath);


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void QuitGame() //method to quit the game
    {

        SceneManager.LoadScene(1); //loads the main menu scene

    }

    public void Restart()
    {
        SceneManager.LoadScene(0); //reloads the game scene
    }

    public void AssignData()
    {
        PlayerName.text = MainMenuController.ApprovedPlayerName + " - " + cc.cd[3].CollectibleNum; // assigns player name and score to GUI text
        DiamondScore.text = cc.cd[0].CollectibleNum.ToString(); //takes data from the collectibles array and assigns it to GUI text
        CubieScore.text = cc.cd[1].CollectibleNum.ToString();
        HexagonScore.text = cc.cd[2].CollectibleNum.ToString();
        AnkhScore.text = cc.cd[6].CollectibleNum.ToString();
        Steps.text = cc.cd[4].CollectibleNum.ToString();
        TimeTaken.text = cc.cd[5].CollectibleName.ToString();

        Hs1.text = (Hs.Hs[0].HighscoreNum + " - " + Hs.Hs[0].HighscoreName).ToString(); //takes data from the highscore array and assigns it to GUI text
        Hs2.text = (Hs.Hs[1].HighscoreNum + " - " + Hs.Hs[1].HighscoreName).ToString();
        Hs3.text = (Hs.Hs[2].HighscoreNum + " - " + Hs.Hs[2].HighscoreName).ToString();
        Hs4.text = (Hs.Hs[3].HighscoreNum + " - " + Hs.Hs[3].HighscoreName).ToString();
        Hs5.text = (Hs.Hs[4].HighscoreNum + " - " + Hs.Hs[4].HighscoreName).ToString();


    }

    public void AssignHighScore()
    {
        Hs.Hs[5].HighscoreNum = cc.cd[3].CollectibleNum;  //takes the playes details and assigns it to the buffer area of the highscores array
        Hs.Hs[5].HighscoreName = MainMenuController.ApprovedPlayerName;
    }


    public void SortHighScore()
    {
        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            for (int j = 0; j < Hs.Hs.Length - i - 1; j++)
            {
                if (Hs.Hs[j].HighscoreNum < Hs.Hs[j + 1].HighscoreNum)
                {
                    tempNum.HighscoreNum = Hs.Hs[j + 1].HighscoreNum;
                    Hs.Hs[j + 1].HighscoreNum = Hs.Hs[j].HighscoreNum;
                    Hs.Hs[j].HighscoreNum = tempNum.HighscoreNum;

                    tempName.HighscoreName = Hs.Hs[j + 1].HighscoreName;
                    Hs.Hs[j + 1].HighscoreName = Hs.Hs[j].HighscoreName;
                    Hs.Hs[j].HighscoreName = tempName.HighscoreName;


                }

            }
        }

    }
    public void SaveData()  // method to save the highscores array
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Create(Application.persistentDataPath + "/Highscores.dat");
        bf.Serialize(fs, Hs.Hs);
        fs.Close();
        Debug.Log("Data saved.");

    }
}



