using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Top_System : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {		
	}

	public void start_ClickButton(){
		SceneManager.LoadScene ("Sense/PONG_game");
	}
}
