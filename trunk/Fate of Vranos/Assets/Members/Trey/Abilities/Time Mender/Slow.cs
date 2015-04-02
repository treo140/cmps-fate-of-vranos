using UnityEngine;
using System.Collections;

public class Slow : BaseAbility {
	
	public void SlowAbility(){
		AbilityName = "Slow";
		AbilityDescription = "Slow down an enemy";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
