using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMoney : MonoBehaviour {

	public Text moneyDisplay;

	public static float money;

	// Use this for initialization
	void Start () {
		money = 0;
		moneyDisplay.text = "Money: $" + money;
	}
	
	// Update is called once per frame
	void Update () {
		moneyDisplay.text = "Money: $" + money;
	}
}
