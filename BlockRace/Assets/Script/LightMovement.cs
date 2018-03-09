using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightMovement : MonoBehaviour {
	public Transform sphereposition; 
	public Vector3 vect;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = sphereposition.position + vect;
		transform.LookAt(sphereposition);
	}
}
