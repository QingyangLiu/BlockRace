using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newstarting : MonoBehaviour {

	// Use this for initialization
	public void PlayGame(){
		
		SceneManager.LoadScene ("GameplayScene");
	}

	public void OptionsMenu(){
		SceneManager.LoadScene ("Options");
	}
}
