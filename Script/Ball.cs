using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private float speed = 10.0f;
	public static int score1,score2;
	public static bool flag1=false,flag2=false;

	// Use this for initialization
	void Start () {
		this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Impulse);
		score1 = 0;
		score2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		

	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "judge1") {
			Debug.Log ("OnTriggerEnter1");
			score1++;
		} else if (other.gameObject.tag == "judge2") {
			Debug.Log ("OnTriggerEnter2");
			score2++;
		} else if(other.gameObject.tag =="pp"){
			Vector3 temp = gameObject.transform.localScale;
//			Vector3 temp1 = gameObject.transform;
			temp.x *= -1;

			gameObject.transform.localScale = temp;
			this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed, ForceMode.Force);
		}

	}

}
