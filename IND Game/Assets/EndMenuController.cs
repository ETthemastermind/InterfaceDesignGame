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
        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();

        GameObject Hsgo = GameObject.Find("HighScoreController");
        Hs = Hsgo.GetComponent<HighScoreController>();


        AssignHighScore();
        SortHighScore();
        AssignData();
        SaveData();

        Debug.Log(Application.persistentDataPath);


    }

    // Update is called once per frame
    void Update()
    {

    }
    public void QuitGame()
    {

        SceneManager.LoadScene(1);

    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void AssignData()
    {
        PlayerName.text = MainMenuController.ApprovedPlayerName + " - " + cc.cd[3].CollectibleNum;
        DiamondScore.text = cc.cd[0].CollectibleNum.ToString();
        CubieScore.text = cc.cd[1].CollectibleNum.ToString();
        HexagonScore.text = cc.cd[2].CollectibleNum.ToString();
        AnkhScore.text = cc.cd[6].CollectibleNum.ToString();
        Steps.text = cc.cd[4].CollectibleNum.ToString();
        TimeTaken.text = cc.cd[5].CollectibleName.ToString();

        Hs1.text = Hs.Hs[0].Highscore;
        Hs2.text = Hs.Hs[1].Highscore;
        Hs3.text = Hs.Hs[2].Highscore;
        Hs4.text = Hs.Hs[3].Highscore;
        Hs5.text = Hs.Hs[4].Highscore;


    }

    public void AssignHighScore()
    {
        Hs.Hs[5].Highscore = (cc.cd[3].CollectibleNum + " achieved by " + MainMenuController.ApprovedPlayerName).ToString();

    }


    public void SortHighScore()
    {
        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            TempHs.Add(Hs.Hs[i].Highscore);
            //Debug.Log("Unsorted" + TempHs[i]);
        }
        

        TempHs.Sort();
        TempHs.Reverse();



        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            Debug.Log(TempHs[i]);
        }



        for (int i = 0; i < Hs.Hs.Length; i++)
        {
            Hs.Hs[i].Highscore = TempHs[i];
        }
        






    }
    public void SaveData()
    {

        BinaryFormatter bf = new BinaryFormatter();
        FileStream fs = File.Create(Application.persistentDataPath + "/Highscores.dat");
        bf.Serialize(fs, Hs.Hs);
        fs.Close();
        Debug.Log("Data saved.");

    }
}



