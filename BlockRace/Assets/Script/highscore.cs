using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highscore : MonoBehaviour {
	Text thistext;
	// Use this for initialization
	void Start () {
		thistext = gameObject.GetComponent<Text> ();
		thistext.text = "Highest Score: " + PlayerPrefs.GetInt ("HighScore").ToString()+"m";
	}
	
	 //Update is called once per frame
	void Update () {
		thistext.text = "Highest Score: " + PlayerPrefs.GetInt ("HighScore").ToString()+"m";
	}
}
