using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthposition : MonoBehaviour {

	public GameObject spherelocation;
	Vector3 currentposition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (spherelocation.transform.hasChanged) {
			Vector3 wantedPos = Camera.main.WorldToScreenPoint (spherelocation.transform.position);
			wantedPos.x = wantedPos.x + 5;
			wantedPos.y = transform.position.y;
			wantedPos.z = transform.position.z;
			if (spherelocation.transform.position.x < 4.5 && spherelocation.transform.position.x > -4.5) {
				transform.position = Vector3.Lerp (transform.position, wantedPos, 10);
			}

		}
	}
}
