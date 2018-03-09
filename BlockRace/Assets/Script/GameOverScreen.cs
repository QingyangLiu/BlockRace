using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverScreen : MonoBehaviour {
	public GameObject sphere;
	public GameObject endscreen;
	// Use this for initialization
	void Start () {
		endscreen.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		if (sphere.activeSelf==false){
			StartCoroutine (restartscreen ());
			
	}
}

	IEnumerator restartscreen(){
		yield return new WaitForSeconds (1);
		if (endscreen.activeSelf == false) {
			endscreen.SetActive (true);
		}
	}
	}
