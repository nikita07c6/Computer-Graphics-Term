using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{

    public Transform target;

    Transform camera;

    // Use this for initialization
    void Start()
    {
        camera = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dist = camera.position - target.position;
        dist = Vector3.Normalize(dist);
        if (Input.GetMouseButton(0))
        {
            transform.RotateAround(target.position, Vector3.left, Input.GetAxis("Mouse Y") * 10f);
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * 10f);
        }
        camera.position = camera.position - dist * Input.GetAxis("Mouse ScrollWheel") * 10f;
    }
    public void positionReset()
    {
        camera.position = target.position + Vector3.back * 15f;
        camera.LookAt(target);
    }
}