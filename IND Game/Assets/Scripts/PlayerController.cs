﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent agent;
    RaycastHit hit;
    private Animator myAnim;
    private float dist;
    Quaternion newRotation;
    float rotSpeed = 5f;

    public Material Char1;
    public Material Char2;
    public Material Char3;

   

	Quaternion savedRot;

    public Text PlayerName;
    public GameObject MummyCharacter;

    private bool isMoving = false;

    private AudioSource running;
    [SerializeField] private AudioClip Clip;
    private Rigidbody rb;
   

    

    public Vector3 Destination;
    public GameObject WaypointObject; 
	private GameObject wayPoint;
	//WayPoint wayPoint; 
	//UPDATE(
	/*
	 * if (wayPoint != NULL)
	 * {
	 * 	Destroy(WayPoint);
	 * }
	 * 
	 *wayPoint = (GameObject)Intantiate(waypoint prefab, pos); 
	 *
	 * 
	 * 
	 * 
	 * */

    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();
        if (MainMenuController.CharSelected == 1)
        {
            Debug.Log("Use Texture 1");
        }
        else if (MainMenuController.CharSelected == 2)
        {
            Debug.Log("Use Texture 2");
        }
        else if (MainMenuController.CharSelected == 3)
        {
            Debug.Log("Use Texture 3");
        }

        AssignPlayerName();
        AssignPlayerMaterial();


        rb = gameObject.GetComponent<Rigidbody>();

        running = gameObject.GetComponent<AudioSource>();

        

        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject())
        {
            //Debug.Log("MOUSE clicked");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            



            if (Physics.Raycast(ray, out hit))
            {
                //Debug.Log("got target");

                agent.SetDestination(hit.point);
                Destination = hit.point;
                //Debug.Log(Destination);
                myAnim.SetBool("IsRunning", true);
                isMoving = true;
                running.Play();

                if (wayPoint != null) 
				{
					Destroy(wayPoint);
				}

				wayPoint = (GameObject)Instantiate(WaypointObject, Destination, Quaternion.identity);






            }
        }

        dist = Vector3.Distance(hit.point, transform.position);
        
        if (dist < 1f)
        {
            myAnim.SetBool("IsRunning", false);
            isMoving = false;
            running.Stop();

        }


        Vector3 relativePos = hit.point - transform.position;
        newRotation = Quaternion.LookRotation(relativePos, Vector3.up);
        newRotation.x = 0.0f;
        newRotation.z = 0.0f;

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotSpeed * Time.deltaTime);


        //StepCalc();

        if (rb.velocity.magnitude > 0)
        {
            
            Debug.Log("pitter patter");
        }
        else
        {
            
        }



        

    }
    public void AssignPlayerName()
    {
        Debug.Log(MainMenuController.ApprovedPlayerName);
        PlayerName.text = MainMenuController.ApprovedPlayerName;
    }

    public void AssignPlayerMaterial()
    {
        if (MainMenuController.CharSelected == 1)
        {
            MummyCharacter.GetComponent<Renderer>().material = Char1;
        }
        else if (MainMenuController.CharSelected == 2)
        {
            MummyCharacter.GetComponent<Renderer>().material = Char2;
        }
        else if (MainMenuController.CharSelected == 3)
        {
            MummyCharacter.GetComponent<Renderer>().material = Char3;
        }
    }

    
}



