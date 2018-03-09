using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class settofalse : MonoBehaviour {
	public GameObject sphere;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (sphere.activeSelf == false) {
			gameObject.SetActive (false);
		}
	}
}
