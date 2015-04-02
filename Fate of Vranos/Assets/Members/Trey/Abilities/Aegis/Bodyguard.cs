using UnityEngine;
using System.Collections;

public class Bodyguard : BaseAbility {
	
	public void BodyguardAbility(){
		AbilityName = "Bodyguard";
		AbilityDescription = "The Aegis recieves a percentage of damage for the selected party member for 3 turns.";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
