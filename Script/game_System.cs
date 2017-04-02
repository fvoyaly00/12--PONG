using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_System : MonoBehaviour {

	public Text Score1,Score2,Stop_b;
	public GameObject Win_p1,Win_p2,Stop;
	private bool flag_stop;

	public struct Number{
		public int point;

		public Number(int poi){
			point=poi;
		}
	}
       Number P1 = new Number (0);
       Number P2 = new Number (0);

		

	// Use this for initialization
	void Start () {
		flag_stop = true;
		Score1 = GameObject.Find ("PLAYER1_sc").GetComponent<Text> ();
		Score2 = GameObject.Find ("PLAYER2_sc").GetComponent<Text> ();
		Stop_b = GameObject.Find ("Button_S").GetComponentInChildren<Text> ();
		Win_p1 = GameObject.Find ("WIN_P1");
		Win_p2 = GameObject.Find ("WIN_P2");
		Stop = GameObject.Find ("STOP");
		Win_p1.SetActive (false);
		Win_p2.SetActive (false);
		Stop.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		P1.point = Ball.score1;
		P2.point = Ball.score2;
		Judge ();
		Score1.text = P1.point.ToString();
		Score2.text = P2.point.ToString();
	}

	void Judge(){
		if (P1.point == 11){
			Debug.Log ("win");
			Win_p1.SetActive (true);
			Time.timeScale = 0;
		}else if(P2.point == 11){
			Win_p2.SetActive (true);
			Time.timeScale = 0;
		}
	}

	public void stop_game(){
		if (flag_stop) {
			Stop_b.text = "restart";
			Stop.SetActive (true);
			Time.timeScale = 0;
			flag_stop = false;
		} else {
			Stop_b.text = "stop";
			Stop.SetActive (false);
			Time.timeScale = 1;
			flag_stop = true;
		}
	}
	}





