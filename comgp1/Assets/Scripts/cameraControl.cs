using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour
{

    public Transform target;
    public Transform helper;

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
            helper.Rotate(Vector3.up, Input.GetAxis("Mouse X") * 5f);
            transform.RotateAround(helper.position, helper.transform.right, Input.GetAxis("Mouse Y") * -5f);
            transform.RotateAround(target.position, Vector3.up, Input.GetAxis("Mouse X") * 5f);
        }
        camera.position = camera.position - dist * Input.GetAxis("Mouse ScrollWheel") * 10f;
    }
    public void positionReset()
    {
        camera.position = target.position + Vector3.back * 15f;
        camera.LookAt(target);
        helper.rotation = Quaternion.identity;
    }
}