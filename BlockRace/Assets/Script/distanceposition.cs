using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distanceposition : MonoBehaviour {

	public Transform spherelocation;
	Vector3 currentposition;
	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		if (spherelocation.position.y>0 && Input.GetAxis("Horizontal")!=0) {
			Vector3 wantedPos = Camera.main.WorldToScreenPoint (spherelocation.position);
			wantedPos.x = wantedPos.x + 40;
			wantedPos.y = transform.position.y;
			wantedPos.z = transform.position.z;
			transform.position = Vector3.Lerp (transform.position, wantedPos, 10);

		}
	}
}
