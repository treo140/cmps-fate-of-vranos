using UnityEngine;
using System.Collections;

public class InnerFury :  BaseAbility {
	
	public void InnerFuryAbility(){
		AbilityName = "Inner Fury";
		AbilityDescription = "Increase attack power";
		AbilityType = 0;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
