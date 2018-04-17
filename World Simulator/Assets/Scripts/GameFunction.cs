using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameFunction : MonoBehaviour {

	public float collectSpeed = 1;
	public float salary;
	public float price;
	public bool locked;
	public Material[] materials;
	public Text priceTag;

	private float nextCollect = 0.0f;
	private float myTime = 0.0f;
	private Renderer rend;

	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer> ();
		nextCollect = collectSpeed;
		if (locked) {
			rend.sharedMaterial = materials [1];
			GetComponent<Rotator>().enabled = false;
			priceTag.text = "$" + price;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if (locked) {
			if (Input.GetMouseButtonDown (0) && DisplayMoney.money - price >= 0) {
				locked = false;
				rend.sharedMaterial = materials [0];
				GetComponent<Rotator> ().enabled = true;
				priceTag.enabled = false;
			}
		} else {
			myTime += Time.deltaTime;
			if (myTime >= nextCollect) {
				nextCollect = myTime + collectSpeed;
				DisplayMoney.money += salary;
				nextCollect -= myTime;
				myTime = 0.0f;
			}
		}
	}
}
