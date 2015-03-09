using UnityEngine;
using System.Collections;

public class TurnManager : MonoBehaviour {

	// Battlers health bars
	public UISlider _playerHealthBar;
	public UISlider _enemyHealthBar;
	public UILabel _victoryLabel;
	public UIRoot _UIRoot;

	public GameObject chooseSpellGrid;
	public UILabel chooseSpellLabel;

	private UIButton[] _spellButtons;

	// Battler Game Objects
	private GameObject _player;
	private GameObject _enemy;

	private GameObject _spawner1;
	private GameObject _spawner2;

	// Battler Stats
	private PlayerStats _playerStats;
	private PlayerStats _enemyStats;

	// Battler Battle Managers
	private PlayerBattleManager _playerBattleManager;
	private EnemyBattleManager _enemyBattleManager;

	// Player battle controller
	// Used for ending the battle after player wins
	private PlayerBattleController _playerBattleController;
	private EnemyBattleController _enemyBattleController;

	// Quest Manager
	private QuestManager _questManager;

	private Respawn _respawn;

	public int playerTurns;
	public int enemyTurns;
	// Use this for initialization
	void Start () {

		Messenger.AddListener("startBattle", StartBattle);
		Messenger.AddListener ("disableButtons", DisableButtons);
		Messenger.AddListener("playerEndTurn", PlayerEndTurn);
		Messenger.AddListener("enemyEndTurn", EnemyEndTurn);

		//_victoryLabel.enabled = false;
		_spawner1 = GameObject.Find ("Start Spawner");
		_spawner2 = GameObject.Find ("Beach Spawner");
	}

	void StartBattle() {
		chooseSpellGrid.SetActive(true);
		chooseSpellLabel.gameObject.SetActive (true);
		chooseSpellLabel.text = "Choose 3 spells";

		// Getting player and enemy entities
		_player = GameObject.FindGameObjectWithTag("Player");
		PlayerBattleManager _playerComponent = _player.GetComponent<PlayerBattleManager>();
		_enemy = _playerComponent.GetEnemy ();

		// Get the stats for the entities
		_playerStats = _player.GetComponent<PlayerStats>();
		_enemyStats = _enemy.GetComponent<PlayerStats>();

		// Get the managers
		_playerBattleManager = _player.GetComponent<PlayerBattleManager>();
		_enemyBattleManager = _enemy.GetComponent<EnemyBattleManager>();

		// Get the battle controller
		_playerBattleController = _player.GetComponent<PlayerBattleController>();
		_enemyBattleController = _enemy.GetComponent<EnemyBattleController> ();

		// Get the spell buttons
		_spellButtons = _UIRoot.GetAllComponentsInChildren<UIButton>();

		// Set the GUI correctly
		_playerHealthBar.value = _playerStats.currentHealth / _playerStats.totalHealth;
		_enemyHealthBar.value = _enemyStats.currentHealth / _enemyStats.totalHealth;
			
		_respawn = _player.GetComponent<Respawn> ();

		_questManager = _player.GetComponent<QuestManager> ();
		_playerBattleController.currentCam = 0;

		//Set the number of turns each fighter gets
		playerTurns = _playerStats.speed;
		enemyTurns = _enemyStats.speed;

		foreach (UIButton button in _spellButtons){
			button.isEnabled = true;
		}
	}

	public void PlayerEndTurn() {
		_playerHealthBar.value = _playerStats.currentHealth / _playerStats.totalHealth;
		_enemyHealthBar.value = _enemyStats.currentHealth / _enemyStats.totalHealth;


		/* We need to disable player abilities right now until enemy is done attacking
		foreach( UIButton button in _spellButtons) {
			button.isEnabled = false;
		}*/

		// Check to see if enemy is dead
		if (_enemyStats.currentHealth <= 0 ) {
			// Enemy is dead, play victory and return to location (show gui button?)
			_spawner1.GetComponent<EnemySpawner>().StartRespawnTimer();
			_spawner2.GetComponent<EnemySpawner>().StartRespawnTimer();
			//Messenger.Broadcast ("endBattle");

			_victoryLabel.enabled = true;
			_victoryLabel.text = "Victory!";

			foreach (UIButton button in _spellButtons){
				button.gameObject.SetActive(false);
			}

			//Make enemy fall through stage
			CapsuleCollider col = _enemy.GetComponent<CapsuleCollider> ();
			Destroy (col);

			NavMeshAgent nav = _enemy.GetComponent<NavMeshAgent> ();
			nav.enabled = false;

			//_enemy.transform.position -= Vector3.up*5*Time.deltaTime;

			StartCoroutine(EndBattle());

			//Update Quest once enemy is defeated.
			if( _questManager.storyProgress == _enemyStats.missionNumber &
			   _questManager.currentQuest.progress < _questManager.currentQuest.condition & 
			    _questManager.currentQuest.active){
				_questManager.currentQuest.progress++;
				_questManager.updateQuest();
			}
			
			Messenger.Broadcast("stopBattleMusic");


		} else {
			if(playerTurns == 1){
				enemyTurns = _enemyStats.speed;
				_enemyBattleManager.TakeTurn();
			}
			else
				playerTurns--;
		}
	}

	public void EnemyEndTurn() {
		_playerHealthBar.value = _playerStats.currentHealth / _playerStats.totalHealth;
		_enemyHealthBar.value = _enemyStats.currentHealth / _enemyStats.totalHealth;
	

		//If the enemy has no more turns left, then enable the gui
		if(enemyTurns == 1){
			playerTurns = _playerStats.speed;
			foreach(UIButton button in _spellButtons) {
				button.isEnabled = true;
			}
		}
		else
			enemyTurns--;


		// Check to see if player is dead
		if (_playerStats.currentHealth <= 0 ) {
			// Player is dead, play defeat and restart (or whatever)
			_victoryLabel.enabled = true;
			_victoryLabel.text = "Defeat...";

			foreach (UIButton button in _spellButtons){
				button.gameObject.SetActive(false);
			}

			//CapsuleCollider col = _player.GetComponent<CapsuleCollider> ();
			//col.enabled = false;

			StartCoroutine(EndBattle());
		}
		_playerBattleController.currentCam = 0;
		// We can reenable player abilities aftesr this


	}
	


	IEnumerator EndBattle() {
		yield return new WaitForSeconds (5f);
		_playerBattleController.EndBattle();
		if (_playerStats.currentHealth <= 0) {
			_player.transform.position = _respawn.Pos;
		}
		//_playerStats.EndBattle();
		_enemyBattleManager.EndBattle();
		_victoryLabel.text = "";

	}

	void DisableButtons() {
		// We need to disable player abilities right now until enemy is done attacking
		foreach (UIButton button in _spellButtons) {
				button.isEnabled = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
