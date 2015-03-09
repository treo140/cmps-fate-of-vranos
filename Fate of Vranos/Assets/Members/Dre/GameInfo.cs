using UnityEngine;
using System.Collections;

public class GameInfo : MonoBehaviour {

	//Boolean to control if battles are active;
	//public static GameObject currentEnemy;
	public static bool playerSeen = false;


	// Use this for initialization
	void Start () {
		//currentEnemy = new GameObject();
	}
	
	// Update is called once per frame
	void Update () {

		//currentEnemy.SetActive (true);
	}

	void OnTriggerEnter(Collider col){
		if (col.tag == "Player"){
			playerSeen = true;
		}	
	}

	void OnTriggerStay(Collider col){		
		if (playerSeen & col.tag == "Enemy") {
			EnemyBattleController enemy = col.GetComponent<EnemyBattleController>();
			enemy.canMove = true;
		}else if (!playerSeen & col.tag == "Enemy") {
			EnemyBattleController enemy = col.GetComponent<EnemyBattleController> ();
			enemy.canMove = false;
		}
	}

	void OnTriggerExit(Collider col){
		if (col.tag == "Player")
			playerSeen = false;
	}
	
}
