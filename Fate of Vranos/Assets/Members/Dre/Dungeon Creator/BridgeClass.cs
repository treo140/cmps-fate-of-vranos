using UnityEngine;
using System.Collections;

public class BridgeClass : MonoBehaviour {
	public PlatformClass platform1;
	public PlatformClass platform2;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public bool activate(){
		if (platform1.enabled == platform2.enabled) {
			print ("activate returned false");
			return false;
		} else {
			return true;
		}
	}
}
