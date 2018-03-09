using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnStart : MonoBehaviour {
	//public GameObject originalbridge;
	//public GameObject startingpoint;
	public GameObject spawningbridge;
	GameObject currentstart;
	GameObject currentbridge;
	public GameObject cube;
	List<GameObject> Cubes=new List<GameObject>();
	int numcubes=0;
	Vector3 Startingposition;
	//public Rigidbody rb;
	// Use this for initialization
	void Start () {
		Startingposition = transform.position;
		//currentstart = Instantiate (startingpoint, transform.position, spawningbridge.transform.rotation);
		Quaternion.Euler(new Vector3(0,0,0));
		currentbridge = Instantiate (spawningbridge, new Vector3(0,0,0), Quaternion.Euler(new Vector3(0,0,0)));


	}
	
	// Update is called once per frame
	void Update () {
//		if (Vector3.Distance (transform.position, currentstart.transform.position) > distance) {
//			this.numcubes = 0;
//			Destroy (currentstart);
//			currentstart = Instantiate (startingpoint, transform.position, transform.rotation);
//
//		}
		if (gameObject!=null && transform.position.y > 0) {
			spawnBridge ();

			spawnCubes ();
		}

	}
	void spawnBridge(){
			if ( Vector3.Distance (transform.position, currentbridge.transform.position) > 200) {
			GameObject tempbridge = currentbridge;
			Destroy (currentbridge);

			currentbridge=Instantiate(spawningbridge, tempbridge.transform.position+Vector3.forward*tempbridge.transform.localScale.z, Quaternion.Euler(new Vector3(0,0,0)));
		}
	}

	void spawnCubes(){
		if (Vector3.Distance (transform.position, Startingposition) > 8) {
			//Vector3 CubePosition = new Vector3 (Random.Range (-5, 5), 1, transform.position.z + 40);

			for (int i = 0; i < Random.Range(0,3); i++) {
				Cubes.Add (Instantiate (cube, new Vector3 (Random.Range (-5f, 5f), 0.5f, transform.position.z + 65), Quaternion.Euler(new Vector3(0,0,0))));
			}
			numcubes++;
			Startingposition = transform.position;
		}
		for (int i = 0; i < Cubes.Count; i++) {

			if (Cubes [i] != null && Vector3.Distance (transform.position, Cubes [i].transform.position) > 70) {
				Destroy (Cubes [i]);
				Cubes.RemoveAt (i);
			} else if (Cubes [i] == null) {
				Cubes.RemoveAt (i);
			}

		}
	}
}
