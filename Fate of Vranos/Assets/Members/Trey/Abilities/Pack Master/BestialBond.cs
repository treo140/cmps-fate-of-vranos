using UnityEngine;
using System.Collections;

public class BestialBond :  BaseAbility {
	
	public void BestialBondAbility(){
		AbilityName = "Bestial Bond";
		AbilityDescription = "Increase the speed and attack of the Pack Master.";
		AbilityType = 0;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}