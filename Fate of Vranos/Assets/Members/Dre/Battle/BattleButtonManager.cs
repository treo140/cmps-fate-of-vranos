using UnityEngine;
using System.Collections;

public class BattleButtonManager : MonoBehaviour {

	private TurnManager turnManager;

	// Use this for initialization
	void Start () {
		turnManager = gameObject.GetComponent<TurnManager> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}


}
