﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUDController : MonoBehaviour {

	public Text timeText;
	private float startTime;

    public Text Steps;
    public GameObject WaypointObjects;
    private string GetSteps;

	// Use this for initialization
	void Start () 
	{
		startTime = Time.time;	
	}
	
	// Update is called once per frame
	void Update () 
	{
		float t = Time.time - startTime;
		string minutes = ((int)t / 60).ToString ("00");
		string seconds = (t % 60).ToString ("00");
		timeText.text = minutes + ":" + seconds;

        Steps.text = WaypointScript.Steps.ToString();
        



    }
}
