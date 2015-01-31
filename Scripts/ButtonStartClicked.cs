using UnityEngine;
using System.Collections;

public class ButtonStartClicked : MonoBehaviour {

	public GameObject inActive;
	public GameObject active;

	void OnClick(){
		inActive.SetActive(true);
		active.SetActive(false);
	}
}
