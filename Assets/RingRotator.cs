using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingRotator : MonoBehaviour {

	public float speed;

	//private float parentSpeed;

	void Start() {
		//parentSpeed = this.transform.parent.GetComponent<Rotator> ().speed;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (new Vector3 (0, 0, 1) * speed); // + new Vector3 (0, 0, -1) * speed);
	}
}
