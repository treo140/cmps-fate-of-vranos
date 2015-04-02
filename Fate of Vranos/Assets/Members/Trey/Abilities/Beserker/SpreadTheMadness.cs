using UnityEngine;
using System.Collections;

public class SpreadTheMadness :  BaseAbility {
	
	public void SpreadTheMadnessAbility(){
		AbilityName = "Spread the Madness";
		AbilityDescription = "Dramatically increase the attack and health of all party members for several turns.";
		AbilityType = 1;
		AbilityTier = 5; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}