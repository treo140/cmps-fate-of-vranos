using UnityEngine;
using System.Collections;

public class OneWithTheBlood :  BaseAbility {
	
	public void OneWithTheBloodAbility(){
		AbilityName = "One With The Blood";
		AbilityDescription = "Increase the effectiveness of Rage.";
		AbilityType = 0;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
