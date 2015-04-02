using UnityEngine;
using System.Collections;

public class NinjaStep : BaseAbility {
	
	public void NinjaStepAbility(){
		AbilityName = "Ninja Step";
		AbilityDescription = "Increases the assassin's speed.";
		AbilityType = 0;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
