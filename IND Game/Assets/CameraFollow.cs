using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform player;
    public float SmoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 Velocity = Vector3.zero;


    private void LateUpdate()
    {
        transform.position = Vector3.SmoothDamp(transform.position, player.position + offset, ref Velocity, SmoothSpeed * Time.deltaTime);
    }
}
