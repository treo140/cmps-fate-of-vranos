using UnityEngine;
using System.Collections;

public class AdvancedTamingMethods :  BaseAbility {
	
	public void AdvancedTamingMethodsAbility(){
		AbilityName = "Advanced Taming Methods";
		AbilityDescription = "The Pack Master has discovered methods to make his animal allies deadlier, raising all summoned animals stats.";
		AbilityType = 0;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}