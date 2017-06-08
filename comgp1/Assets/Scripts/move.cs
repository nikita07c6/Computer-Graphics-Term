using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {
    public GameObject nucleus;
    public float x;
    public float y;
    public float z;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.RotateAround(nucleus.transform.position, new Vector3(x, y, z), 45*Time.deltaTime);
	}
}
