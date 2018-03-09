using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceleratorControl : MonoBehaviour {
	public Rigidbody rb;
	Vector3 originalposition;
	// Use this for initialization
	void Start () {
		rb = gameObject.GetComponent<Rigidbody> ();
		originalposition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.acceleration.x > 0.05f) {
//			transform.position = Vector3.Lerp (transform.position, transform.position + Vector3.right * 2000 * Input.acceleration.x * Time.deltaTime, 1f * Time.deltaTime);
//			//transform.position = transform.position + Vector3.right *30* Input.acceleration.x*Time.deltaTime;
//		} else if (Input.acceleration.x < -0.05f) {
//			transform.position = Vector3.Lerp (transform.position, transform.position + Vector3.right * 2000 * Input.acceleration.x * Time.deltaTime, 1f * Time.deltaTime);
//		}

		Vector3 acceleration=Input.acceleration;
		originalposition = new Vector3 (originalposition.x, transform.position.y, transform.position.z);
		transform.position = Vector3.Lerp (transform.position, originalposition + new Vector3 (acceleration.x, 0, 0)*150f, 0.5f*Time.deltaTime);
		//transform.position=originalposition+new Vector3(acceleration.x, 0,0)*100f*Time.deltaTime;

	}
}
