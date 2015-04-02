using UnityEngine;
using System.Collections;

public class Rocket : BaseAbility {
	
	public void RocketAbility(){
		AbilityName = "Rocket";
		AbilityDescription = "Unleash a rocket from the future.";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
