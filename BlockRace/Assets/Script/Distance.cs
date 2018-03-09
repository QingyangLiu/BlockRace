using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Distance : MonoBehaviour {
	Text text;
	public Transform sphereposition;
	public int spherepositionz;
	float originalposition;
	// Use this for initialization
	void Start () {
		text = gameObject.GetComponent<Text> ();
		originalposition = sphereposition.position.z;
	}
	
	// Update is called once per frame
	void Update () {
		spherepositionz =((int) sphereposition.position.z - (int)originalposition)/10;
		text.text = "Distance "+spherepositionz.ToString()+"m";
	}
}
