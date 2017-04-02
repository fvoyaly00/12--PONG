using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {

	private int minite;				
	private float second;
	//private int second_before;
	public  Text time;


	// Use this for initialization
	void Start () {
		minite = 0;
		second = 0;
		//second_before = 0;
		time=GameObject.Find("time").GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		second += Time.deltaTime;
		if (second >= 60.0f) {
			minite++;
			second = second - 60;
			}
		time.text = minite.ToString ("00") + ":" + ((int)second).ToString ("00");
		
	}
}

