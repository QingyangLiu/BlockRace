using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthTotal : MonoBehaviour {
	public GameObject sphere;
	blockmove move;
	Slider slide;

	// Use this for initialization
	void Start () {
		move = sphere.GetComponent<blockmove> ();
		slide = gameObject.GetComponent<Slider> ();

	}
	
	// Update is called once per frame
	void Update () {
		if (move != null) {
			slide.value = move.health/10;
		}
		if (sphere.activeSelf == false) {
			gameObject.SetActive (false);
		}
	}
}
