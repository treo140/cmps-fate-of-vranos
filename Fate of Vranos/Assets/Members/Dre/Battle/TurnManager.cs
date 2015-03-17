﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TurnManager : MonoBehaviour {



	// Compares entity objects for us when sorting
	public class entityComparer : IComparer<Entity>
	{
		// returns
		//		-1 if x < y
		//		 0 if x = y
		//		 1 if x > y
		public int Compare(Entity x, Entity y)
		{
			if(x is PlayerEntity)
			{
				if(y is PlayerEntity) return y.speed - x.speed;
				else return -1;
			}
			else
			{
				if(y is PlayerEntity) return 1;
				else return y.speed - x.speed;
			}
		}
	}

	public enum BattleStates
	{
		NoBattle,
		Start,
		MoveSelection,
		MoveExecution,
		Outcome
	}

	public BattleStates currentState = BattleStates.NoBattle;

	public List<Entity> people = new List<Entity>();
	public List<Entity> turnQueue = new List<Entity>();

	public List<List<Transform>> targets = new List<List<Transform>>();

	public Entity turnPlayer;

	public List<Spell> turnPlayerSpells;

	public int tempCharge;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (currentState) 
		{
		case BattleStates.NoBattle:
			//List should be empty
			break;

		case BattleStates.Start:
			//List should be populated by this point


			//List gets sort into the order of fastest to slowest			
			turnQueue.Sort (new entityComparer ());
			turnPlayer = turnQueue[0];
			MakeSpellButtons();
			currentState = BattleStates.MoveSelection;
			break;

		case BattleStates.MoveSelection:
			//Each player chooses moves until one of the following criteria are met:
			//turn is passed, player uses all charges, player does not have enough resource for any
			//move(Player can choose to charge), player decides to not choose anymore moves, or player
			// can not move(due to a spell effect i.e. stun/frozen)

			//Manager should go into MoveExecution after each single player finished choosing moves
			//currentState = BattleStates.MoveExecution;

			break;

		case BattleStates.MoveExecution:
			//Moves are executed in the order in which they where added to the move execution list

			//After all the moves are executed in the list, Manager should go into the Outcome phase.
			currentState = BattleStates.Outcome;

			break;

		case BattleStates.Outcome:
			//Apply Buff/Debuff/DOT/HOT
			
			//Check if all players are dead, if so go to Lose()
			bool allAlliesDead = true;
			foreach(Entity person in people)
			{
				if(person is PlayerEntity)
				{
					if(person.currentHealth > 0)
					{
						allAlliesDead = false;
					}
				}
			}
			if(allAlliesDead)
			{
				Lose();
				break;
			}

			
			//Check if all enemies are dead, if so go to Win()
			bool allEnemiesDead = true;
			foreach(Entity person in people)
			{
				if(person is EnemyEntity)
				{
					if(person.currentHealth > 0)
					{
						allEnemiesDead = false;
					}
				}
			}
			if(allEnemiesDead)
			{
				Win();
				break;
			}

			 

			turnQueue.Remove(turnPlayer);
			if(turnQueue.Count <= 0)
			{
				foreach(Entity person in people)
				{
					turnQueue.Add(person);
				}
			}
			currentState = BattleStates.Start;

			break;

		default:
			break;

		}

	
	}

	public void AddAlly(Entity ally)
	{
		people.Insert (people.IndexOf (turnPlayer) + 1, ally);

	}

	public void PopulateList(List<Entity> PlayerParty, List<Entity> EnemyParty)
	{
		foreach (Entity ally in PlayerParty) 
		{
			people.Add (ally);
			turnQueue.Add(ally);
		}

		foreach (Entity enemy in EnemyParty) 
		{
			people.Add (enemy);
			turnQueue.Add(enemy);
		}

		currentState = BattleStates.Start;
	}

	public void Win()
	{
		turnQueue.Clear ();
		turnPlayerSpells.Clear ();
		currentState = BattleStates.NoBattle;
	}

	public void Lose()
	{
		turnQueue.Clear ();
		turnPlayerSpells.Clear ();
		currentState = BattleStates.NoBattle;
	}

	public void addSpell(Spell spell)
	{
		tempCharge -= spell.Cost;
		turnPlayerSpells.Add (spell);
		ChooseTargets (spell);

	}
	public void MakeSpellButtons()
	{
		//clear UIgrid for attacks
		//add charge button to the list
		foreach (Spell spell in turnPlayer.knownSpells) 
		{
			//make new UIButton from attack button prefab
			AttackButtonScript attackButtonScript = new AttackButtonScript();
			attackButtonScript.spell = spell;
			//add attackButtonScript to UIgrid for attacks
		}
		//add cancel/clear button to the list?
		//add done button to the list
	}
	public void ChooseTargets(Spell spell)
	{
		Transform CurrentTarget = gameObject.transform;
		switch(spell.tarType)
		  {
		  case TargetType.SingleEnemy:
		  		//show enemy target buttons
		  		break;
		  case TargetType.SingleAlly:
		  		//Show ally target buttons
		  		break;
		  default:
			List<Transform> currentTargets = new List<Transform>();
			currentTargets.Add(CurrentTarget);
			targets.Add(currentTargets);
		  		//keep spell select gui on the screen
		  		break;
		  }
		//once confirmed target to list of all targets*/
	}
	public void castSpells(){
	//********************************************************************
	//NEEDS TO BE MODIFIED TO PLAY SPELLS WITHOUT INTURRUPTING EACHOTHER
	//********************************************************************
		foreach(Spell spell in turnPlayerSpells){
			switch(spell.tarType)
			{
				case TargetType.SingleEnemy:
				case TargetType.SingleAlly:
					spell.Cast(targets[turnPlayerSpells.IndexOf(spell)]);
					break;
				default:
					spell.Cast();
					break;
			}
		}
	}
}
