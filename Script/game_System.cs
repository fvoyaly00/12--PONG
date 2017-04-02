using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class game_System : MonoBehaviour {

	public Text Score1,Score2;
	public GameObject Win_p1,Win_p2,Stop;

	public struct Number{
		public int point;
		public bool flag_win;

		public Number(int poi,bool flg){
			point=poi;
			flag_win=flg;
		}
	}
       Number P1 = new Number (0, false);
       Number P2 = new Number (0, false);

		

	// Use this for initialization
	void Start () {
		Score1 = GameObject.Find ("PLAYER1_sc").GetComponent<Text> ();
		Score2 = GameObject.Find ("PLAYER2_sc").GetComponent<Text> ();
		Win_p1 = GameObject.Find ("WIN_P1");
		Win_p1.SetActive (false);
		Win_p2 = GameObject.Find ("WIN_P2");
		Win_p2.SetActive (false);
		Stop = GameObject.Find ("STOP");
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
			P1.flag_win = true;
			Win_p1.SetActive (true);
		}else if(P2.point == 11){
			P1.flag_win = true;
		}
	}



	//public void OnTriggerEnter

}
