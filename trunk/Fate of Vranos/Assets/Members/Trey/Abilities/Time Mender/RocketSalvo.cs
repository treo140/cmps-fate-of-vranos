using UnityEngine;
using System.Collections;

public class RocketSalvo : BaseAbility {
	
	public void RocketSalvoAbility(){
		AbilityName = "Rocket Salvo";
		AbilityDescription = "Rip open a tear in time to unleash several rockets from the future.";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
