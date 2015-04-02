using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerBattleManager : MonoBehaviour {

	private PlayerBattleController _playerBattleController;

	private GameObject enemy;
	public PlayerStats enemyStats;
	private PlayerController animController;
	private EnemyAnimControl _enemyAnimControl;

	private bool cameraMove;
	//public EnemyStats _enemyEntity;

	public List<BaseSpell> spells = new List<BaseSpell>();

	public int movesLeft;

	Turnmanager2 turnManager;
	
	// Use this for initialization
	void Start () {
		movesLeft = GetComponent<PlayerStats> ().speed;
		turnManager = GetComponent<Turnmanager2> ();
		animController = GetComponent<PlayerController> ();
		_playerBattleController = GetComponent<PlayerBattleController> ();

		// Adding the spells to a list
		spells.Add( new FireballOld() );
		spells.Add( new ThunderStrike() );
		spells.Add( new HolyStrike() );
		spells.Add(new FateOfVranos ());
		spells.Add (new Iceball ());
		spells.Add (new Mudball ());

		// Messenger listeners for ending turn
		//Messenger.AddListener ("playerEndTurn", EndTurn());
	}

	void Update() {

		if (Input.GetKeyDown (KeyCode.F12))
			CastFateOfVranos ();
	}

	public void setTarget(GameObject target){
		enemy = target.gameObject;
		enemyStats = enemy.GetComponent<PlayerStats>();
		_enemyAnimControl = enemy.GetComponentInChildren<EnemyAnimControl> ();
	}

	public void StartBattle(Collider other) {

		Debug.Log ("The battle has started!");
		setTarget (other.gameObject);
		foreach (BaseSpell spell in spells)
			spell.TurnsLeft =0;

		Messenger.Broadcast ("startBattle");
	}


	/* Spell Casting Functions */
	public void CastFireball() {
		//if(spells[0].TurnsLeft <= 0)
			TakeTurn (0);
	}

	public void CastThunderStrike() {
		//if(spells[1].TurnsLeft <= 0)
			TakeTurn (1);
	}

	public void CastHolyStrike() {
		//if(spells[2].TurnsLeft <= 0)
			TakeTurn (2);
	}

	public void CastFateOfVranos() {
		//if(spells[3].TurnsLeft <= 0)
			TakeTurn (3);
	}
	
	public void CastIceBAll() {
		//if(spells[4].TurnsLeft <= 0)
			TakeTurn (4);
	}
	
	public void CastMudball() {
		//if(spells[5].TurnsLeft <= 0)
			TakeTurn (5);
	}

	// Return the enemy if there is one
	public GameObject GetEnemy() {
		if(!enemy){
			Debug.Log ("ERROR: Someone trying to GetEnemy for Player, but none exists! FUCK!");
			return enemy;
		} else {
			return enemy;
		}

	}

	void TakeTurn(int spellIndex) {
		/*_playerBattleController.currentCam = 1;
		animController.Uppercut();
		Debug.Log ("Casting Holy Strike!");
		float damage = spells[spellIndex].SpellDamage;
		spells [spellIndex].Cast ();
		
		_enemyStats.TakeDamage (damage);

		Messenger.Broadcast("playerEndTurn");*/
		//foreach (BaseSpell spell in spells)
		//	spell.TurnsLeft -=1;

		//Add spell to list of spells
		turnManager.turnPlayerSpells.Add(spells[spellIndex]);

		//spells [spellIndex].TurnsLeft = spells [spellIndex].Cooldown;
		//StartCoroutine (MoveCamera ());
		//StartCoroutine (AttackEnemy (spellIndex));
	}


}