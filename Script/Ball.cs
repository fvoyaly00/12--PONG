using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	private float speed1 = 10.0f;
	private float speed2 = 100.0f;
	public static int score1,score2;
	public static bool flag1=false,flag2=false;

	// Use this for initialization
	void Start () {
		Time.timeScale = 1;
		this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed1, ForceMode.Impulse);
		score1 = 0;
		score2 = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "judge1") {
			score1++;
			this.gameObject.transform.position =new Vector3 (0, 0, 0);
			this.gameObject.transform.rotation	= Quaternion.Euler (180, 95, 90);
			this.transform.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed1, ForceMode.Impulse);
		} else if (other.gameObject.tag == "judge2") {
			score2++;
			this.gameObject.transform.position =new Vector3 (0, 0, 0);
			this.gameObject.transform.rotation	= Quaternion.Euler (180, 95, 90);
			this.transform.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
			this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed1*-1, ForceMode.Impulse);
		} else if(other.gameObject.tag =="pp"){
			Vector3 temp = gameObject.transform.localScale;
			temp.x *= -1;

			gameObject.transform.localScale = temp;
			this.GetComponent<Rigidbody> ().AddForce (transform.forward * speed2, ForceMode.Force);
		}

	}
	

}