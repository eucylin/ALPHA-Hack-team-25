using UnityEngine;
using System.Collections;

public class GC : MonoBehaviour {
	
	public int[] randoms;
	public void G_Random(){
		for(int i = 0;i < randoms.Length; i++){
			randoms[i] = Random.Range(1,3);
			}
		}
	void Start(){
		randoms = new int[4];
		G_Random();
	}
}
