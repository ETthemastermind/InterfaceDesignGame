using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	public AudioSource musicSource;

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
		Debug.Log ("Loading Game");
		SceneManager.LoadScene (0);
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








	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
