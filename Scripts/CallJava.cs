using UnityEngine;
using System.Collections;

public class CallJava : MonoBehaviour {
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
			Application.ExternalCall( "SayHello", "The game says hello!" );
			Destroy(this);
	
	}
}
