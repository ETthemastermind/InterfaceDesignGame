using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{

    public Camera camera;
    public NavMeshAgent agent;
    RaycastHit hit;
    private Animator myAnim;
    private float dist;
    Quaternion newRotation;
    float rotSpeed = 5f;

   

	Quaternion savedRot;


    // Use this for initialization
    void Start()
    {
        myAnim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("MOUSE clicked");
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);




            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log("got target");

                agent.SetDestination(hit.point);
                myAnim.SetBool("IsRunning", true);
               

            }
        }

        dist = Vector3.Distance(hit.point, transform.position);
        
        if (dist < 1f)
        {
            myAnim.SetBool("IsRunning", false);
        }


        Vector3 relativePos = hit.point - transform.position;
        newRotation = Quaternion.LookRotation(relativePos, Vector3.up);
        newRotation.x = 0.0f;
        newRotation.z = 0.0f;

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotation, rotSpeed * Time.deltaTime);



        

    }


}



