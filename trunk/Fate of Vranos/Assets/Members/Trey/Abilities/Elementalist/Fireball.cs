using UnityEngine;
using System.Collections;

public class Fireball : BaseAbility {
	
	public void FireballAbility(){
		AbilityName = "Fireball";
		AbilityDescription = "Unleash an inferno on all enemies with a chance of burning.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
