using UnityEngine;
using System.Collections;

public class playGameScript : MonoBehaviour {
	public GameObject StartUI;

	void Start(){
		Time.timeScale = 0.0f;
	}
	// Use this for initialization
	void OnClick() {
		//Application.LoadLevel ("island");
		
		Time.timeScale = 1.0f;
		StartUI.SetActive (false);
	}
}
