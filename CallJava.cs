using UnityEngine;
using System.Collections;

public class CallJava : MonoBehaviour {
	Done_GameController d;
	// Use this for initialization
	void Start () {
		d = GameObject.FindGameObjectWithTag("GameController").GetComponent<Done_GameController>();
	}
	
	// Update is called once per frame
	void Update () {
		if(d.score >= 20f){
			Application.ExternalCall( "SayHello", "The game says hello!" );
			Destroy(this);
		}
	
	}
}
