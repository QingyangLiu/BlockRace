using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighlistTilt : MonoBehaviour {
	Image image;
	public int number;
	// Use this for initialization
	void Awake () {
		image = gameObject.GetComponent<Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (PlayerPrefs.GetInt ("ControlOptions", 1) == number) {
			image.color = new Color32 (255, 99, 99, 255);
		}else{
			image.color = Color.white;
		}
	}
}
