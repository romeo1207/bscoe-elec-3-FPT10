using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIMinimap : MonoBehaviour {
public Quaternion iniRot;
	// Use this for initialization
	void Start () {
        iniRot = transform.rotation;
    }
	
	// Update is called once per frame
	void Update () {
        transform.rotation = iniRot;
    }
}

