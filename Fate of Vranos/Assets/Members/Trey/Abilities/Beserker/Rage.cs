using UnityEngine;
using System.Collections;

public class Rage :  BaseAbility {
	
	public void RageAbility(){
		AbilityName = "Rage";
		AbilityDescription = "Increase your attack power up to a Max of 3 times";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
