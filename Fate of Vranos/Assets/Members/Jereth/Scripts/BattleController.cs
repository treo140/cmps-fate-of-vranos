using UnityEngine;
using System.Collections;

public class BattleController : MonoBehaviour {

	private PlayerController controller;
	public GameObject enemy;

	// Use this for initialization
	void Start () 
	{

		controller = GetComponent<PlayerController> ();

	}
	
	// Update is called once per frame
	void Update () 
	{

	
	}
}
