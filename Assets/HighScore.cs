using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HighScore : MonoBehaviour {
	static public int score = 1000;

	void Awake () {
		if ( PlayerPrefs.HasKey("ApplePickerHighScore") ) {
			score = PlayerPrefs.GetInt("ApplePickerHighScore");
		}

		PlayerPrefs.SetInt("ApplePickerHighScore", score);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GUIText gt = this.GetComponent<GUIText>();
		gt.text = "High Score: " + score;

		if ( score > PlayerPrefs.GetInt("ApplePickerHighScore") ) {
			PlayerPrefs.SetInt("ApplePickerHighScore", score);
		}
	}
}
