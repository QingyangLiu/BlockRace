﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startmethod : MonoBehaviour {

	// Use this for initialization
	void Start () {
		for (int i=0;i<transform.childCount;i++){
			transform.GetChild (i).gameObject.SetActive (true);
		}
	}
	
	// Update is called once per frame

}
