using UnityEngine;
using System.Collections;

public class LightningStorm : BaseAbility {
	
	public void LightningStormAbility(){
		AbilityName = "Lightning Storm";
		AbilityDescription = "Call down the wrath of the storm on all your enemies.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}


