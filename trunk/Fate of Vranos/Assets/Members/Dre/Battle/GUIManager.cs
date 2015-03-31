using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BattleGUIManager : MonoBehaviour {

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

	public Entity turnPlayer;
	public List<Entity> targets = new List<Entity> ();
	
	public int chosenSpell = 0;
	public int chosenTarget = 0;
	public int chosenItem = 0;
	public int chosenAction = 1;
	public int comboListPageNum = 1;

	public BattleStates CurrentState = BattleStates.NoBattle;
	public int selection = 0;

	public int[] outcome;

	// Use this for initialization
	void Start () {
	



		Messenger.AddListener<Entity> ("StartGUI",StartGUI);
		Messenger.AddListener ("SelectAction",SelectAction);
		Messenger.AddListener ("SelectMove",SelectMove);
		Messenger.AddListener ("SelectItem",SelectItem);
		Messenger.AddListener<List<Entity>>("SelectSpellTarget",SelectSpellTarget);
		Messenger.AddListener<List<Entity>>("SelectItemTarget",SelectItemTarget);
		Messenger.AddListener ("ShowComboList",ShowComboList);
		Messenger.AddListener ("ConfirmMove",ConfirmMove);
		Messenger.AddListener ("MoveExecution",MoveExecution);
		Messenger.AddListener ("Outcome",Outcome);
		Messenger.AddListener<bool> ("EndGUI",EndGUI);

		Messenger.AddListener<int>("UpDown", UpDown);


		Messenger.AddListener<int[]> ("SetOutcome", SetOutcome);
	
	}
	
	// Update is called once per frame
	void Update () {
		switch (CurrentState) 
		{
		case BattleStates.NoBattle:
			break;
		case BattleStates.Start:
			break;
		case BattleStates.SelectAction:
			break;
		case BattleStates.ShowComboList:
			break;
		case BattleStates.SelectItem:
			break;
		case BattleStates.SelectItemTarget:
			break;
		case BattleStates.SelectMove:
			break;
		case BattleStates.SelectSpellTarget:
			break;
		case BattleStates.ConfirmMove:
			break;
		case BattleStates.MoveExecution:
			//update health bars
			break;
		case BattleStates.Outcome:
			//update health bars
			break;
		}	
	}

	void OnDisable() {
		Messenger.RemoveListener<Entity> ("StartGUI",StartGUI);
		Messenger.RemoveListener ("SelectAction",SelectAction);
		Messenger.RemoveListener ("SelectMove",SelectMove);
		Messenger.RemoveListener ("SelectItem",SelectItem);
		Messenger.RemoveListener<List<Entity>>("SelectSpellTarget",SelectSpellTarget);
		Messenger.RemoveListener<List<Entity>> ("SelectItemTarget",SelectItemTarget);
		Messenger.RemoveListener ("ShowComboList",ShowComboList);
		Messenger.RemoveListener ("ConfirmMove",ConfirmMove);
		Messenger.RemoveListener ("MoveExecution",MoveExecution);
		Messenger.RemoveListener ("Outcome",Outcome);
		Messenger.RemoveListener<bool> ("EndGUI",EndGUI);
		
		Messenger.RemoveListener<int>("UpDown", UpDown);		
		
		Messenger.RemoveListener<int[]> ("SetOutcome", SetOutcome);
	}

	public void StartGUI(Entity player)
	{
		turnPlayer = player;
		//show main gui
		//show/set party health
		//highlight turn player health


		//disable action list
		//disable item list
		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.Start;
	}
	public void SelectAction()
	{
		//show/un-dim action list

		//disable item list
		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.SelectAction;
	}
	public void ShowComboList()
	{
		//dim action list

		//Show combo list

		
		//disable item list
		//disable move list
		//disable target list
		//disable targeted enemy health
		CurrentState = BattleStates.ShowComboList;
	}
	public void SelectItem()
	{
		//dim action list

		//show item list

		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.SelectItem;
	}

	public void SelectItemTarget(List<Entity> _targets)
	{
		targets = _targets;
		//dim action list
		//dim item list

		//show target list

		//disable move list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.SelectItemTarget;
	}
	public void SelectMove()
	{
		//dim action list

		//show move list	
		
		//disable item list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.SelectMove;
	}
	public void SelectSpellTarget(List<Entity> _targets)
	{
		targets = _targets;
		//dim action list
		//dim move list

		//show target list
		
		//disable item list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.SelectSpellTarget;
	}
	public void ConfirmMove()
	{
		//dim action list
		//dim move list
		//dim target list

		//show/highlight confirm button
		CurrentState = BattleStates.ConfirmMove;
	}
	public void MoveExecution()
	{		
		//dim action list
		
		//disable item list
		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.MoveExecution;
	}
	public void Outcome()
	{
		//dim action list
		
		//disable item list
		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.Outcome;
	}
	public void EndGUI(bool win)
	{
		//dim action list
	
		//show outcome of battle??
			//(pass array of significant numbers)
		//show win or lose

		//disable item list
		//disable move list
		//disable target list
		//disable combo list
		//disable targeted enemy health
		CurrentState = BattleStates.NoBattle;

	}

	public void UpDown(int selection)
	{
		this.selection = selection;

		switch (CurrentState) 
		{
		case BattleStates.SelectAction:
			chosenAction = selection;
			//highlight selected action in action menu
			break;
		case BattleStates.ShowComboList:
			comboListPageNum = selection;
			//show selected page in combo list
			break;
		case BattleStates.SelectItem:
			chosenItem = selection;
			//highlight selected item in item list
			break;
		case BattleStates.SelectItemTarget:
			chosenTarget = selection;
			//highlight selected target in target list
			//if enemy display selected target's info in top right
			//if ally highlight selected target's health bar in bottom right
			break;
		case BattleStates.SelectMove:
			chosenSpell = selection;
			//highlight selected move in move list
			break;
		case BattleStates.SelectSpellTarget:
			chosenTarget = selection;
			//highlight selected target in target list
			//if enemy display selected target's info in top right
			//if ally highlight selected target's health bar in bottom right
			break;
		}
	}

	public void SetOutcome(int[] x)
	{
		outcome = x;
	}

}
