using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class originalplanescript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine(destroyObject());
	}
	
	// Update is called once per frame


	IEnumerator destroyObject(){
		yield return new  WaitForSeconds(10);
		Destroy (gameObject);
	}
}
