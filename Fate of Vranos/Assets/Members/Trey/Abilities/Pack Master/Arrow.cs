using UnityEngine;
using System.Collections;

public class Arrow :  BaseAbility {
	
	public void ArrowAbility(){
		AbilityName = "Arrow";
		AbilityDescription = "";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}