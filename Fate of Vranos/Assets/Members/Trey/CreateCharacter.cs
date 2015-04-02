using UnityEngine;
using System.Collections;

public class CreateCharacter : MonoBehaviour {

	private BasePlayer newPlayer;
	private string playerName = "EnterName";

	bool isWarrior;
	bool isWizard;
	bool isRogue;
	bool isJackofAllTrades;

	// Use this for initialization
	void Start () {	
		newPlayer = new BasePlayer ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI () {
		playerName = GUILayout.TextArea(playerName);							//Creates a text for players to enter their characters(!TEMP!)
		isWarrior = GUILayout.Toggle(isWarrior, "Warrior Class");				//Creates buttons from each of the 4 classes for players to select from(!TEMP!)
		isJackofAllTrades = GUILayout.Toggle(isJackofAllTrades, "Jack of All Trades Class");
		isWizard = GUILayout.Toggle(isWizard, "Wizard Class");
		isRogue = GUILayout.Toggle(isRogue, "Rogue Class");

		if (GUILayout.Button ("Create")) {									//Determines which class the players have selected on the menu
			if (isWarrior) {
				newPlayer.PlayerClass = new Warrior ();
			} else if (isWizard) {
				newPlayer.PlayerClass = new Wizard ();
			} else if (isRogue) {
				newPlayer.PlayerClass = new Rogue ();
			} else if (isJackofAllTrades) {
				newPlayer.PlayerClass = new JackofAllTrades ();
			}

			newPlayer.PlayerName = playerName;									//Sets player name based on what the player entered
			newPlayer.SkillPoints = 10;											//The default amount of skill points that players recieve upon creating their character
			newPlayer.Health = newPlayer.PlayerClass.Health;			        //Sets Stats and Skills based on the choice of class from their default values.
			newPlayer.Focus = newPlayer.PlayerClass.Focus;
			newPlayer.Resistance = newPlayer.PlayerClass.Resistance;
			newPlayer.Speed = newPlayer.PlayerClass.Speed;
			newPlayer.SkillSet1 = newPlayer.PlayerClass.SkillSet1;
			newPlayer.SkillSet2 = newPlayer.PlayerClass.SkillSet2;
			newPlayer.SkillSet3 = newPlayer.PlayerClass.SkillSet3;

			Debug.Log("Player Class: " + newPlayer.PlayerClass);

		}
	

	}


}
