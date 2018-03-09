using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.touchCount>0 && Input.GetTouch (0).position.x > (Camera.main.pixelWidth/2)) {
			transform.position = Vector3.Lerp (transform.position, transform.position + Vector3.right * 800 * 1 * Time.deltaTime, 0.5f * Time.deltaTime);
		} else if (Input.touchCount>0 && Input.GetTouch (0).position.x < (Camera.main.pixelWidth/2)) {
			transform.position = Vector3.Lerp (transform.position, transform.position + Vector3.right * 800 * -1 * Time.deltaTime, 0.5f * Time.deltaTime);
		}
	}
}
