using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LegSpin : MonoBehaviour {
	public float spinFactor;
	void OnCollisionEnter(Collision col){
		Debug.Log("You are in Spin Block");

	}


}
