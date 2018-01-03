using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestLight : MonoBehaviour {

	Light aa;
	void Start () {
		aa = GetComponent<Light>();
		aa.type = LightType.Point;
		//cullingMask 的设置问题
		aa.cullingMask = 5;
	}
	
	void Update () {
		
	}
}
