using UnityEngine;
using System.Collections;

public class GC : MonoBehaviour {

	int MIN = 1;
	int MAX = 16;
	public int[] randoms;
	public int number;
	public GameObject endDrag;
	public Animator black;
	public Animator red;
	int tmp;
	bool counting = false;
	void Update(){
		//PlayAnim();
	}
	/*public void G_Random(){
		randoms[0] = 3;
		randoms[1] = 1;
		randoms[2] = 3;
		randoms[3] = 2;
		for(int i = 0;i < randoms.Length; i++){
			tmp = Random.Range(MIN,MAX);
			if(i > 0 && randoms[i-1] == tmp){
				if(tmp < MAX - 1){
					randoms[i] = tmp + 1;
				}else{
					randoms[i] = tmp - 1;
				}
			}else{
				randoms[i] = tmp;
			}
			Debug.Log (randoms[i]);
			}
		}*/
	void Start(){
		randoms = new int[8];
		number = 1;
		tmp = Random.Range(1, 5);
		switch(tmp)
		{
			case 1:
				R1 ();
				break;
			case 2:
				R2 ();
				break;
			case 3:
				R3 ();
				break;
			default:
				R4 ();
				break;
		}
		//G_Random();
	}
	void R1(){
		randoms[0] = 13;
		randoms[1] = 1;
		randoms[2] = 12;
		randoms[3] = 10;
		randoms[4] = 3;
		randoms[5] = 2;
		randoms[6] = 8;
		randoms[7] = 5;
	}
	void R2(){
		randoms[0] = 8;
		randoms[1] = 9;
		randoms[2] = 6;
		randoms[3] = 12;
		randoms[4] = 7;
		randoms[5] = 11;
		randoms[6] = 14;
		randoms[7] = 1;
	}
	void R3(){
		randoms[0] = 15;
		randoms[1] = 8;
		randoms[2] = 9;
		randoms[3] = 7;
		randoms[4] = 13;
		randoms[5] = 6;
		randoms[6] = 4;
		randoms[7] = 3;
	}
	void R4(){
		randoms[0] = 3;
		randoms[1] = 5;
		randoms[2] = 10;
		randoms[3] = 11;
		randoms[4] = 13;
		randoms[5] = 14;
		randoms[6] = 15;
		randoms[7] = 1;
	}
	public void CountScore(){
		counting = true;
		endDrag.SetActive(true);
	}
	/*void PlayAnim(){
		if(counting && !black.isPlaying){
			black.Play ();
			if(!red.isPlaying){
				red.Play ();
			}
		}
	}*/
}
