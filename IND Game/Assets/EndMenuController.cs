using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndMenuController : MonoBehaviour {

	public CollectiblesController cc;
	public Text PlayerName;
    public Text DiamondScore;
    public Text CubieScore;
    public Text HexagonScore;
	public Text Score;
    public Text Steps;
    public Text TimeTaken;
    

	// Use this for initialization
	void Start ()
	{
		GameObject ccgo = GameObject.Find ("CollectiblesController");
		cc = ccgo.GetComponent<CollectiblesController> ();
		AssignData ();
		
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
		PlayerName.text = MainMenuController.ApprovedPlayerName;
        DiamondScore.text = cc.cd [0].CollectibleNum.ToString ();
        CubieScore.text = cc.cd[1].CollectibleNum.ToString();
        HexagonScore.text = cc.cd[2].CollectibleNum.ToString();
        //Score.text = cc.cd [3].CollectibleNum.ToString ();
        Steps.text = cc.cd[4].CollectibleNum.ToString();
        TimeTaken.text = cc.cd[5].CollectibleName.ToString();

    }

   


}
