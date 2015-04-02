using UnityEngine;
using System.Collections;

public class Reave :  BaseAbility {
	
	public void Ability(){
		AbilityName = "Reave";
		AbilityDescription = "Do a powerful attack at the cost of health.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}