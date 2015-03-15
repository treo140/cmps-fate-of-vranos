using UnityEngine;
using System.Collections;

public class Fireballl : BaseAbility {
	
	public void FireballlAbility(){
		AbilityName = "Fireballl";
		AbilityDescription = "Unleash an inferno on all enemies with a chance of burning.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 10;
	}
	
}
