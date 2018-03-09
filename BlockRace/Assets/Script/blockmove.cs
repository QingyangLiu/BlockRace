using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockmove : MonoBehaviour {
	public Rigidbody rb;
	public float xvelocity;
	public int health;
	bool justHit=false;
	int updatepassedsincelastlit=0;
	// Use this for initialization
	void Awake () {
		if (PlayerPrefs.GetInt ("ControlOptions", 1) == 1) {
			gameObject.GetComponent<AcceleratorControl> ().enabled = true;
			gameObject.GetComponent<TouchControl> ().enabled = false;
		} else if (PlayerPrefs.GetInt ("ControlOptions", 1) == 0) {
			gameObject.GetComponent<AcceleratorControl> ().enabled = false;
			gameObject.GetComponent<TouchControl> ().enabled = true;
		}
		//Cursor.lockState = CursorLockMode.Locked;
		rb.velocity = Vector3.forward*5;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (justHit == true && updatepassedsincelastlit >= 0.25 / Time.deltaTime ) {
			justHit = false;
		} else {
			updatepassedsincelastlit++;
		}
		rb.AddForce (Vector3.down * 50);
		if (transform.position.y > -5) {
			rb.AddForce (0, 0, 100 * Time.deltaTime);
		} else {
			rb.velocity = new Vector3 (0, rb.velocity.y, 0);
			health = 0;
		}
		Debug.Log (rb.velocity.z);
//		if (Input.GetKey ("a")) {
//			transform.position = transform.position + new Vector3 (-xvelocity*Time.deltaTime, 0, 0);
//		}
//		if (Input.GetKey ("d")) {
//			transform.position = transform.position + new Vector3 (xvelocity*Time.deltaTime, 0, 0);
//		}
		float movement = Input.GetAxis ("Horizontal");
		transform.position = Vector3.Lerp (transform.position, transform.position + Vector3.right * 2000 * movement * Time.deltaTime, 1f * Time.deltaTime);



	}
	void Update(){
		if (health <= 0) {
			gameObject.SetActive (false);

		}
	}

	void OnCollisionEnter(Collision collide){
		if (collide.gameObject.name == "Cube(Clone)" && justHit==false) {
			rb.velocity=rb.velocity-Vector3.forward*rb.velocity.z/3;
			health = health - 10;
			justHit = true;
			updatepassedsincelastlit = 0;
		}
	}
}
