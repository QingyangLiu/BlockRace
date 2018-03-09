using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highestscore : MonoBehaviour {
	public Text HighScoreText;
	public Distance distance;
	// Use this for initialization
	void Start () {
		HighScoreText = gameObject.GetComponent<Text> ();
		string highscore = PlayerPrefs.GetInt ("HighScore", 0).ToString()+"m";
		HighScoreText.text = "High Score: " + highscore;
	}
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("q")){
			PlayerPrefs.DeleteAll();
		}
		if (distance.spherepositionz > PlayerPrefs.GetInt("HighScore")) {
			PlayerPrefs.SetInt ("HighScore", distance.spherepositionz);
			HighScoreText.text = "High Score: " + PlayerPrefs.GetInt ("HighScore")+"m";
		}
	}
}
