using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

    public CollectiblesController cc;

    public float GameTimer;
	public static float TimeLeft;
	private bool GameEnded = false;

	public Slider TimeBar;
	public Canvas EndMenu;
    public GameObject HUDCOntroller;

    



    // Use this for initialization
    void Start () 
	{
		TimeLeft = GameTimer;
        

        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();

}
	
	// Update is called once per frame
	void Update () 
	{

		if (TimeLeft > 0 )//&& GameEnded == false) 
		{
			TimeLeft -= Time.deltaTime;
			TimeBar.value = TimeLeft / GameTimer;


			if (TimeLeft < 0) 
			{

				GameEnded = true;
				Debug.Log("Game Over");
				gameObject.SetActive (false);
				EndMenu.gameObject.SetActive (true);
                




				//if (SceneManager.GetActiveScene ().buildIndex == 0) 
				//{

				//	SceneManager.LoadScene (1);
				//}


			}	
				
		}

		if (TimeLeft > GameTimer) 
		{
			TimeLeft = GameTimer;
		}


	}
}
