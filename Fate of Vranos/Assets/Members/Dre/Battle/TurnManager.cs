 using UnityEngine;
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
		SelectItem,
		SelectItemTarget,
		ShowComboList,
		SelectAction,
		SelectMove,
		SelectSpellTarget,
		ConfirmMove,
		MoveExecution,
		Outcome
	}

	public BattleStates currentState = BattleStates.NoBattle;

	public List<Entity> people = new List<Entity>();
	public List<Entity> turnQueue = new List<Entity>();

	public List<GameObject> targets = new List<GameObject>();

	public Entity turnPlayer;

	public List<Spell> turnPlayerSpells;

	public int numTurns;
	public int tempCharge;

	//These represent the maximum values for each of the menus
	public List<Entity> targetsToChoose = new List<Entity>();
	public int spellsToChoose = 0;
	public int actionsToChoose = 3;
	public int itemsToChoose = 0;

	//These represent the current selected item for each menu
	public int chosenSpell = 0;
	public int chosenTarget = 0;
	public int chosenItem = 0;
	public int chosenAction = 1;
		//1 attack
		//2 items
		//3 combo list

	public int comboListPageNum = 1;
	public int comboListPageNumTotal = 3;

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
//*********************************************************
//Start
//*********************************************************
		case BattleStates.Start:
			//List should be populated by this point


			//List gets sort into the order of fastest to slowest			
			turnQueue.Sort (new entityComparer ());
			turnPlayer = turnQueue[0];
			numTurns = turnPlayer.speed;
			currentState = BattleStates.SelectAction;
			break;
			//Each player chooses moves until one of the following criteria are met:
			//turn is passed, player uses all charges, player does not have enough resource for any
			//move(Player can choose to charge), player decides to not choose anymore moves, or player
			// can not move(due to a spell effect i.e. stun/frozen)
			
			//Manager should go into MoveExecution after each single player finished choosing moves
			//currentState = BattleStates.MoveExecution;
			
//*********************************************************
//SELECT ACTION
//*********************************************************
		case BattleStates.SelectAction:
			//choose atack items or combo list
			if(Input.GetButtonDown("Fire1"))
			{
				switch(chosenAction)
				{
				case 1: 
					currentState = BattleStates.SelectMove;
					break;
				case 2:
					currentState = BattleStates.SelectItem;
					break;
				case 3:
					currentState = BattleStates.ShowComboList;
					break;
				default:
					break;
				}
			}
			else if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
			{
				if(chosenAction < actionsToChoose)
					chosenAction++;
				else 
					chosenAction = 0;
			}
			else if(Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
			{				
				if(chosenAction > 0)
					chosenAction--;
				else 
					chosenAction = actionsToChoose;
			}
			else if(Input.GetButtonDown("Fire2"))
			{
				chosenAction = 1;
			}
			break;
//*********************************************************
//SELECT ITEM
//*********************************************************
		case BattleStates.SelectItem:
			if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
			{
				if(chosenItem < itemsToChoose)
					chosenItem++;
				else 
					chosenItem = 0;
			}
			else if(Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
			{				
				if(chosenItem > 0)
					chosenItem--;
				else 
					chosenItem = itemsToChoose;
			}
			else if (Input.GetButtonDown("Fire1"))
			{
				if(itemsToChoose > 0)
				{
					//add spell for item to turnplayerspells;
					currentState = BattleStates.SelectItemTarget;
				}
			}
			else if (Input.GetButtonDown("Fire2"))
			{			
				chosenItem = 0;
				currentState = BattleStates.SelectAction;
			}
			break;
//*********************************************************
//SELECT ITEM TARGET
//*********************************************************
		case BattleStates.SelectItemTarget:
			if(targetsToChoose.Count <= 0)
			{
				foreach(Entity possibletarget in people)
					if(possibletarget is PlayerEntity)
						targetsToChoose.Add(possibletarget);
			}

			if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
			{
				if(chosenTarget < targetsToChoose.Count)
					chosenTarget++;
				else
					chosenTarget = 0;
			}
			else if(Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
			{
				if(chosenTarget > 0)
					chosenTarget--;
				else
					chosenTarget = targetsToChoose.Count;
			}
			else if(Input.GetButtonDown("Fire1"))
			{
				targets.Add(targetsToChoose[chosenTarget].gameObject);
				chosenTarget = 0;
				targetsToChoose.Clear();

				currentState = BattleStates.MoveExecution;
			}
			else if(Input.GetButtonDown("Fire2"))
			{
				turnPlayerSpells.RemoveAt(turnPlayerSpells.Count - 1);
				targetsToChoose.Clear();
				currentState = BattleStates.SelectItem;
				chosenTarget = 0;
			}
			break;
//*********************************************************
//SHOW COMBO LIST
//*********************************************************
		case BattleStates.ShowComboList:
			if(Input.GetButtonDown("Fire2"))
			{
				currentState = BattleStates.SelectAction;
			}
			else if(Input.GetButtonDown("Fire1"))
			{
				if(comboListPageNum < comboListPageNumTotal)
				{
					comboListPageNum++;
				}
				else
				{					
					currentState = BattleStates.SelectAction;
				}
			}
			break;			
//*********************************************************
//SELECT MOVE
//*********************************************************
		case BattleStates.SelectMove:
			//chose spell from list of turnplayer spells
			if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
			{
				if(chosenSpell < turnPlayer.knownSpells.Count - 1)
					chosenSpell++;
				else 
					chosenSpell = 0;
				while(turnPlayer.knownSpells[chosenSpell].Cost > tempCharge){
					if (chosenSpell < turnPlayer.knownSpells.Count - 1)
						chosenSpell++;
					else
						chosenSpell = 0;
				}
			}
			else if(Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
			{
				if(chosenSpell > 0)
					chosenSpell--;
				else 
					chosenSpell = turnPlayer.knownSpells.Count - 1;
				while(turnPlayer.knownSpells[chosenSpell].Cost > tempCharge){
					if (chosenSpell > 0)
						chosenSpell--;
					else
						chosenSpell = turnPlayer.knownSpells.Count - 1;
				}
			}
			else if(Input.GetButtonDown("Fire1"))
			{
				addSpell(turnPlayer.knownSpells[chosenSpell]);
				currentState = BattleStates.SelectSpellTarget;
				chosenSpell = 0;
			}
			else if(Input.GetButtonDown("Fire2"))
			{
				if(turnPlayerSpells.Count > 0){	
					tempCharge += turnPlayerSpells.Last().Cost;			
					turnPlayerSpells.RemoveAt(turnPlayerSpells.Count - 1);
					targets.RemoveAt(turnPlayerSpells.Count - 1);
					numTurns++;
				}
				else
				{
					currentState = BattleStates.SelectAction;
					chosenSpell = 0;
				}
			}
			break;
//*********************************************************
//SELECT SPELL TARGET
//*********************************************************
		case BattleStates.SelectSpellTarget:
			switch(turnPlayer.knownSpells[chosenSpell].tarType)
			{
			case TargetType.SingleEnemy:
				if( targetsToChoose.Count <= 0)
				{
					foreach(Entity possibletarget in people)
						if( possibletarget is EnemyEntity && possibletarget.health > 0.0f)
							targetsToChoose.Add(possibletarget);
				}
				break;
			case TargetType.SingleAlly:
				if( targetsToChoose.Count <= 0)
				{
					foreach(Entity possibletarget in people)
						if(possibletarget is PlayerEntity)
							targetsToChoose.Add(possibletarget);
				}
				break;
			default:
				GameObject CurrentTarget = new GameObject();
				targets.Add(CurrentTarget);

				numTurns --;
				if(numTurns > 0)
				{
					currentState = BattleStates.SelectMove;
				}
				else
				{
					currentState = BattleStates.ConfirmMove;
				}
				break;
			}		
			
			if(Input.GetAxis("Vertical") > 0 || Input.GetAxis("Horizontal") > 0)
			{
				if(chosenTarget < targetsToChoose.Count)
					chosenTarget++;
				else
					chosenTarget = 0;
			}
			else if(Input.GetAxis("Vertical") < 0 || Input.GetAxis("Horizontal") < 0)
			{
				if(chosenTarget > 0)
					chosenTarget--;
				else
					chosenTarget = targetsToChoose.Count;
			}
			else if(Input.GetButtonDown("Fire1"))
			{
				targets.Add(targetsToChoose[chosenTarget].gameObject);
				chosenTarget = 0;
				targetsToChoose.Clear();
				
				numTurns --;
				if(numTurns > 0)
				{
					currentState = BattleStates.SelectMove;
				}
				else
				{
					currentState = BattleStates.ConfirmMove;
				}
			}
			else if(Input.GetButtonDown("Fire2"))
			{
				tempCharge += turnPlayerSpells.Last().Cost;	
				turnPlayerSpells.RemoveAt(turnPlayerSpells.Count - 1);
				targetsToChoose.Clear();
				currentState = BattleStates.SelectMove;
				chosenTarget = 0;
			}
			break;
//*********************************************************
//Confirm Move
//*********************************************************
		case BattleStates.ConfirmMove:
			if(Input.GetButtonDown("Fire1"))
			{
				currentState = BattleStates.MoveExecution;
			}
			else if(Input.GetButtonDown("Fire2"))
			{	
				tempCharge += turnPlayerSpells.Last().Cost;				
				turnPlayerSpells.RemoveAt(turnPlayerSpells.Count - 1);
				targets.RemoveAt(turnPlayerSpells.Count - 1);
				numTurns++;
				currentState = BattleStates.SelectMove;
			}
			break;
//*********************************************************
//Move Execution
//*********************************************************
		case BattleStates.MoveExecution:
			//Moves are executed in the order in which they where added to the move execution list
			castSpells();
			//After all the moves are executed in the list, Manager should go into the Outcome phase.
			currentState = BattleStates.Outcome;

			break;
//*********************************************************
//Outcome
//*********************************************************
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

	}



	public void castSpells(){
	//********************************************************************
	//NEEDS TO BE MODIFIED TO PLAY SPELLS WITHOUT INTURRUPTING EACHOTHER
	//********************************************************************

		foreach(Spell spell in turnPlayerSpells){
			//subtract cost from player charge
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
