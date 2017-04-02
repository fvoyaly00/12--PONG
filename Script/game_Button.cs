using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class game_Button : MonoBehaviour {

	GameObject refobj;

	// Use this for initialization
	void Start () {
		refobj = GameObject.Find ("System");
	}
	
	// Update is called once per frame
	void Update () {		
	}
	public void top_button(){
		SceneManager.LoadScene ("Sense/PONG_top");
	}

	public void reset_button(){
		SceneManager.LoadScene ("Sense/PONG_game");
	}

	public void stop_button(){
		game_System g1 = refobj.GetComponent<game_System> ();
		g1.stop_game ();

	}
}
