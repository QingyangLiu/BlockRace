using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehavior : MonoBehaviour {

	public GameObject shatter;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.name=="Sphere") {
			Instantiate (shatter, transform.position, transform.rotation);
			Destroy (gameObject);
		}
	}
}
