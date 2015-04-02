using UnityEngine;
using System.Collections;

public class Smash :  BaseAbility {
	
	public void SmashAbility(){
		AbilityName = "Smash";
		AbilityDescription = "SMASH!!!!!";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}