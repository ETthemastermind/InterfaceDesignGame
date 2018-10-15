using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent agent;
    RaycastHit hit;


    // Use this for initialization
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("mOUSE clicked");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {

                agent.SetDestination(hit.point);
               

            }

        }

        

    }


}



