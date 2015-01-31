using UnityEngine;
using System.Collections;

public class GC : MonoBehaviour {

	int MIN = 1;
	int MAX = 10;
	public int[] randoms;
	public int number;
	int tmp;
	public void G_Random(){
		/*randoms[0] = 3;
		randoms[1] = 1;
		randoms[2] = 3;
		randoms[3] = 2;*/
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
		}
	void Start(){
		randoms = new int[10];
		number = 1;
		G_Random();
	}
}
