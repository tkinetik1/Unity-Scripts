//Created by Tyson Frederick, 8/9/2014, with Official "Live Training" video from Unity3D.com; net.tkinetik.tyson.frederick

using UnityEngine;
using System.Collections;

public class Resetter : MonoBehaviour {

	public Rigidbody2D projectile;
	public float resetSpeed = 0.025f;

	private float resetSpeedSqr;
	private SpringJoint2D spring;
	
	void Start () {
		resetSpeedSqr = resetSpeed * resetSpeed;
		spring = projectile.GetComponent <SpringJoint2D>();
	}

	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			Reset ();
		}

		if (spring == null && projectile.velocity.sqrMagnitude < resetSpeedSqr) {
			Reset ();		
		}
	}

	void OnTriggerExit2D (Collider2D other) {
		if (other.rigidbody2D == projectile) {
			Reset ();	
		}
	}

	void Reset () {
		Application.LoadLevel (Application.loadedLevel);
	}
}
