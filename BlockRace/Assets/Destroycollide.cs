using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroycollide : MonoBehaviour {

	void Awake(){
		StartCoroutine (destroyroutine ());
	}

	IEnumerator destroyroutine(){
		yield return new WaitForSeconds (1f);
		Destroy (gameObject);
	}
}
