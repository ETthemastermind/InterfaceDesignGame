using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraOrbit : MonoBehaviour {

    public Transform CameraJig;
    public float rotateSpeed;

    private void LateUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.RotateAround(CameraJig.position, Vector3.up, rotateSpeed * Time.deltaTime);
        }


        if (Input.GetKey(KeyCode.A))
        {
            transform.RotateAround(CameraJig.position, -Vector3.up, rotateSpeed * Time.deltaTime);
        }
    }
}
