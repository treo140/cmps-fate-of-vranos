using UnityEngine;
using System.Collections;

public class Backstab : BaseAbility {
	
	public void BackstabAbility(){
		AbilityName = "Backstab";
		AbilityDescription = "Has a high chance to perform a critical strike.";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
