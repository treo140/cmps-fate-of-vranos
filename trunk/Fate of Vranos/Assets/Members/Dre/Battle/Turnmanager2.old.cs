using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Turnmanager2 : MonoBehaviour {

	public enum BattleStates{
		start,
		moveSelect,
		moveExecute,
		win,
		lose
	}

	public BattleStates CurrentBattleState = BattleStates.start;

	public List<PlayerStats> allPlayers;
	public PlayerStats turnPlayer;

	//list of moves/spells
	public List<BaseSpell> turnPlayerSpells;

	private bool cameraMove;
	
	private PlayerController animController;
	private EnemyAnimControl _enemyAnimControl;
	private PlayerBattleController _playerBattleController;	
	private PlayerBattleManager playerBattleManager;

	// Use this for initialization
	void Start () {		
		animController = GetComponent<PlayerController> ();
		_playerBattleController = GetComponent<PlayerBattleController> ();
		playerBattleManager = GetComponent<PlayerBattleManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		switch (CurrentBattleState) {
		case BattleStates.start:
			//add allies to list of all players
			//add enemies to list of all players
			//make move buttons and add them to gui
			//make target buttons and add them to gui

			//set first player
			turnPlayer = allPlayers[0];
			break;
		case BattleStates.moveSelect:
			//Select move for turn player
			//if turn player is ally
				//show move select gui and focus camera on ally
			//else
				//call function to pick enemy moves
			break;
		case BattleStates.moveExecute:
			//hide move select gui
			//for each spell in list of spells 
				//cast spell and remove from list of spells
				//update health bars
				//check for win
			foreach(BaseSpell spell in turnPlayerSpells){
				StartCoroutine (MoveCamera ());
				StartCoroutine (AttackEnemy (spell));
			}

			//select the next turn player
			if(allPlayers.IndexOf(turnPlayer) < (allPlayers.Count -1)){
				turnPlayer = allPlayers[allPlayers.IndexOf(turnPlayer)+1];
			}else{
				turnPlayer = allPlayers[0];
			}
			break;
		case BattleStates.win:
			break;
		case BattleStates.lose:
			break;		
		}
	}

	IEnumerator MoveCamera() {
		Messenger.Broadcast ("disableButtons");
		cameraMove = false;
		_playerBattleController.currentCam = 1;
		yield return new WaitForSeconds(.3f);
		cameraMove = true;
	}
	
	IEnumerator AttackEnemy(BaseSpell spell) {
		
		while (!cameraMove)
			yield return new WaitForSeconds (0.1f);
		
		animController.Uppercut();
		Debug.Log ("Casting Holy Strike!");
		float damage = spell.SpellDamage;
		spell.Cast (transform);
		
		playerBattleManager.enemyStats.TakeDamage (damage);
		_enemyAnimControl.GetHit ();
		yield return new WaitForSeconds (1);
		Messenger.Broadcast("playerEndTurn");
		_enemyAnimControl.ResetHit ();
		
	}
}
