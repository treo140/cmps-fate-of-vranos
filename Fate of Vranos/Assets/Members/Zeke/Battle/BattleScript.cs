using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleScript : MonoBehaviour {

	private PlayerBattleManager _player;
	private GameObject _enemy;

	// Use this for initialization
	void Start () {

		List<BaseSpell> spells = new List<BaseSpell>();
		spells.Add( new Fireball() );
		_player = GetComponent<PlayerBattleManager>();

		Messenger.AddListener("startBattle", startBattle);
	
	}

	void startBattle () {

		// Enemy first turn

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
