using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOptions : MonoBehaviour {

	public void TiltOption(){
		PlayerPrefs.SetInt ("ControlOptions", 1);
	}
	public void TapOption(){
		PlayerPrefs.SetInt ("ControlOptions", 0);
	}
	public void ReturnToMenu(){
		SceneManager.LoadScene ("New Scene");
	}
	public void ReturnToGame(){
		SceneManager.LoadScene ("GameplayScene");
	}
}
