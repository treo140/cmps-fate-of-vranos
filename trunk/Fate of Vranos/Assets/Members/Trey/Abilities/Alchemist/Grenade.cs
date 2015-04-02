using UnityEngine;
using System.Collections;

public class Grenade : BaseAbility {
	
	public void GrenadeAbility(){
		AbilityName = "Grenade";
		AbilityDescription = "Toss a weak grenade at an enemy.";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

