using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_System : MonoBehaviour {

	GameObject Player1,Player2;
	Vector3 _player;
	Camera _camera;


	// Use this for initialization
	void Start () {
		Player1 = GameObject.Find ("player1");
		Player2 = GameObject.Find ("player2");
	}
	
	// Update is called once per frame
	void Update () {
		LorR ();
	}

	public void LorR(){
		for (int i = 0; i < Input.touchCount; i++) {

			var pos = Input.touches [i].position;
			_player = new Vector3 (pos.x, pos.y, 0);

			var p = _camera.ScreenToWorldPoint(_player);

			if (pos.x < -5.0) {
				//var P1_id = Input.touches [i].fingerId;
				Player1.transform.position = new Vector3 (-5, p.y, 0);
			} else if (pos.x > 5.0) {
				//var P2_id = Input.touches [i].fingerId;
				Player2.transform.position = new Vector3 (5, p.y, 0);
			}
		}
	}
}
