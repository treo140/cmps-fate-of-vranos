using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyBattleManager : MonoBehaviour {
	
	private GameObject player;
	private PlayerStats playerStats;
	private PlayerStats myStats;

	private PlayerBattleController _playerBattleController;
	private bool moveCamera;

	private EnemyAnimControl _enemyAnimControl;
	private PlayerController _playerController;


	private BaseSpell[] enemySpells = new BaseSpell[5];

	// Use this for initialization
	void Start () {
		Messenger.AddListener ("enemyTurn", TakeTurn);
		myStats = GetComponent<PlayerStats>();

		player = GameObject.FindGameObjectWithTag ("Player");
		_playerBattleController = player.GetComponent<PlayerBattleController> ();

		_enemyAnimControl = GetComponentInChildren<EnemyAnimControl> ();
		_playerController = player.GetComponent<PlayerController> ();

		enemySpells [0] = new Mudball(gameObject);
		enemySpells [1] = new FireballOld(gameObject);
		enemySpells [2] = new ThunderStrike(gameObject);
		enemySpells [3] = new Iceball(gameObject);
		enemySpells [4] = new FateOfVranos();

	}
	
	public void StartBattle(Collider other) {
		player = other.gameObject;	
		_playerBattleController = player.GetComponent<PlayerBattleController> ();	
	}

	void OnTriggerEnter(Collider other) {
		if(other.tag == "Player") {
			Debug.Log ("I got the player, hahahahahaaaa!");
			player = other.gameObject;
			playerStats = player.GetComponent<PlayerStats>();
		}

	}

	public void TakeTurn() {
		StartCoroutine (MoveCamera ());
		StartCoroutine(Attack());
	}

	public void EndBattle() {
		Destroy (gameObject);
	}

	public void Drop(){
		CapsuleCollider col = GetComponent<CapsuleCollider> ();
		Destroy (col);
	}

	IEnumerator MoveCamera() {
		moveCamera = false;
		yield return new WaitForSeconds (2);
		_playerBattleController.currentCam = 2;
		yield return new WaitForSeconds (1);
		moveCamera = true;

	}

	// cast fireball
	IEnumerator Attack() {

		// while camerabool
		// yield return new WaitForSeconds(1.0f);

		while (!moveCamera)
				yield return new WaitForSeconds (.1f);


		_enemyAnimControl.StartAttack ();
		if (myStats.missionNumber == 0) {
			yield return new WaitForSeconds (.7f);			
		}
		enemySpells[myStats.missionNumber].Cast (transform);
		yield return new WaitForSeconds(.1f);
		_enemyAnimControl.ResetAttack ();


		Debug.Log ("My turn! Attacking player!");
		float damage = myStats.attack;
		playerStats.TakeDamage(damage);
		yield return new WaitForSeconds(1f);
		Messenger.Broadcast("enemyEndTurn");
	}

}
