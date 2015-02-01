using UnityEngine;
using System.Collections;

public class ButtonStartClicked : MonoBehaviour {

	//public GameObject inActive;
	public GameObject active;
	GC gc;
	void OnClick(){
		gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GC>();
		//inActive.SetActive(true);
		Debug.Log ("ADOG" + gc.randoms[0]);
		Application.ExternalCall("Finish");
		GameObject.Find ("QuestionPanel_" + gc.randoms[0]).transform.Find("Window").gameObject.SetActive(true);
		GameObject.Find ("LeftPanel_" + gc.randoms[0]).transform.Find("Label - Title").gameObject.SetActive(true);
		GameObject.Find ("LeftPanel_" + gc.randoms[0]).transform.Find("Picture").gameObject.SetActive(true);
		active.SetActive(false);
	}
}
