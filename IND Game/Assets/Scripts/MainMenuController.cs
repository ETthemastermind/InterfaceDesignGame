using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour {

	public AudioSource musicSource;
    public static int CharSelected;
    public InputField PlayerNameTextBox;
    public static string ApprovedPlayerName;
    private bool PlayerNameApproved = false;

    



    public void PlayMusic()
	{
		if (musicSource.isPlaying) 
		{
			musicSource.Pause();
		} else 
		{
			musicSource.Play()
			;
		}

	}

  


	public void SetFullScreen (bool isFullScreen )
	{
		Screen.fullScreen = isFullScreen;
	}

	public void StartGame()
	{
        if (MainMenuController.CharSelected != 0 && PlayerNameApproved == true)
        {
            Debug.Log("Loading Game");
            SceneManager.LoadScene(0);
        }
		
	}

	public void QuitGame()
	{

		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Debug.Log ("Quitting Game");
		Application.Quit ();
		#endif
	}

    public void Char1Selection()
    {
        CharSelected =1 ;
        Debug.Log(CharSelected);
    }

    public void Char2Selection()
    {
        CharSelected = 2;
        Debug.Log(CharSelected);
    }

    public void Char3Selection()
    {
        CharSelected = 3;
        Debug.Log(CharSelected);
    }

    public void GetPlayerName()
    {

      
        if (PlayerNameTextBox.text == "")
        {
            Debug.Log("This name is not suffcient");
            PlayerNameApproved = false;
        }
        else
        {
            
            PlayerNameApproved = true;
            Debug.Log("ApprovedPlayerName");
            ApprovedPlayerName = PlayerNameTextBox.text;
            
        }
        
    }






    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
