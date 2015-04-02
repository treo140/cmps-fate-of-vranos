using UnityEngine;
using System.Collections;

public class Trap :  BaseAbility {
	
	public void TrapAbility(){
		AbilityName = "Trap";
		AbilityDescription = "Trap an enemy, slowing down their speed drastically.";
		AbilityType = 1;
		AbilityTier = 4; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}