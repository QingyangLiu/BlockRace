using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public void restartgame(){
		SceneManager.LoadScene ("GameplayScene");
		gameObject.SetActive (false);
	}
	public void getoptions(){
		SceneManager.LoadScene ("Options");
		gameObject.SetActive (false);
	}

}
