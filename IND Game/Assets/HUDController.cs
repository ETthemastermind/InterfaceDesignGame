using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class HUDController : MonoBehaviour {

	public Text timeText;
	private float startTime;



    public Text Steps;
    public GameObject WaypointObjects;
    private string GetSteps;

	public CollectiblesController cc;
	public Text DiamondScore;
	public Text HexagonScore;
	public Text CubieScore;
	public Text TotalScore;

    public Animator PlacesAnim;

	public Canvas EndMenu;
	public Text PlayerName;
	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;	
		GameObject ccgo = GameObject.Find ("CollectiblesController");
		cc = ccgo.GetComponent<CollectiblesController> ();

        PlacesAnim.enabled = false;

		Time.timeScale = 1;
	}
	
	// Update is called once per frame
	void Update () 
	{
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ("00");
		string seconds = (t % 60).ToString ("00");
		timeText.text = minutes + ":" + seconds;

        Steps.text = WaypointScript.Steps.ToString();

		DiamondScore.text = cc.cd [0].CollectibleNum.ToString ();
		CubieScore.text = cc.cd [1].CollectibleNum.ToString ();
		HexagonScore.text = cc.cd [2].CollectibleNum.ToString ();
		TotalScore.text = cc.cd [3].CollectibleNum.ToString ();

        cc.cd[5].CollectibleName = timeText.text;




    }

    public void ShowMenu()
    {
        PlacesAnim.enabled = true;
        PlacesAnim.Play("SlidingScroll");
    }




}
