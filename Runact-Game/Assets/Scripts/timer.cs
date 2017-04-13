using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class timer : MonoBehaviour {
	float TimeRemaining = 60;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
		TimeRemaining -= Time.deltaTime;
	}

	void OnGUI(){

		if (TimeRemaining > 0) {
			GUI.Label (new Rect (100, 100, 200, 200), "Time Remaining:" +(int)TimeRemaining);
		} else {
			SceneManager.LoadScene ("GameOver"); 
		}
			
	}
}
