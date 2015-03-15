using UnityEngine;
using System.Collections;

public class Rogue : BaseCharacterClass {
	
	public void RogueClass(){
		
		ClassName = "Rogue";
		ClassDescription = "Is the quickest character in the game. Has access to the Alchemist, Assassin, and Pack Master skill trees";
		Health = 60;
		Focus = 50;
		Resistance = 15;
		Speed = 60;
		SkillSet1 = new Alchemist();
		SkillSet2 = new Assassin();
		SkillSet3 = new PackMaster();


	}
}

