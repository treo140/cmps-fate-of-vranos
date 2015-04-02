using UnityEngine;
using System.Collections;

public class Howl :  BaseAbility {
	
	public void HowlAbility(){
		AbilityName = "Howl";
		AbilityDescription = "Howl at the enemy to demoralize them and break down their defenses.";
		AbilityType = 1;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}