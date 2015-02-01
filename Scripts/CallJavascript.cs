using UnityEngine;
using System.Collections;

public class CallJavascript : MonoBehaviour {

	void OnClick(){
		CallJs ();
	}

	void CallJs(){
		Application.ExternalCall("Finish");
	}
}
/*
 * ingredient1
 * function(){
 * url = "http://xxxxx.php" + document.search + 
 * document.location.href = url;
 * }*/