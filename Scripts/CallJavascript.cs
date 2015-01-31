using UnityEngine;
using System.Collections;

public class CallJavascript : MonoBehaviour {

	void OnClick(){
		CallJs ();
	}

	void CallJs(){
		Application.ExternalCall( "SwitchPage", "7" );
	}
}
