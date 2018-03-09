using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour {
	public Vector3 vect;
	public Transform sphereposition;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	//	if (sphereposition.transform.position.y >= 0.5) {
		if (sphereposition != null) {
			transform.position = new Vector3 (transform.position.x, transform.position.y, sphereposition.transform.position.z) + vect;
		}
			//}
		//transform.position = sphereposition.position+vect;
	}
}
