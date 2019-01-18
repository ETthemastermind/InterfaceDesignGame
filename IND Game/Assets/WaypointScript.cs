using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointScript : MonoBehaviour {

    private float StartTime;
    public float StepPeriod;
    public static int Steps;
    public CollectiblesController cc;

 
   


	// Use this for initialization
	void Start ()
    {
        StartTime = Time.time;

        GameObject ccgo = GameObject.Find("CollectiblesController");
        cc = ccgo.GetComponent<CollectiblesController>();

    }
	
	// Update is called once per frame
	void Update ()
    {
        CountSteps();
    }

    private void OnTriggerEnter(Collider other)
    {
		if (other.gameObject.tag == "Player")
        {
            
            Debug.Log("Collided with Player");
            Destroy(gameObject);
            
        }
    }


    private void CountSteps()
    {

        if (Time.time > StartTime)
        {
            StartTime += StepPeriod;
            Steps = Steps + 1;
            //Debug.Log(Steps);
            cc.cd[4].CollectibleNum = Steps;
            
            
        }
    }
}
