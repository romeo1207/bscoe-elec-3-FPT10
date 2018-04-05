using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Finder : MonoBehaviour {
    public Transform destinationPoint;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.GetComponent<NavMeshAgent>().destination = destinationPoint.position;
	}
}
