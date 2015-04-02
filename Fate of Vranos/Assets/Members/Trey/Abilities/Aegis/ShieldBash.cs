using UnityEngine;
using System.Collections;

public class ShieldBash : BaseAbility {
	
	public void ShieldAbility(){
		AbilityName = "Shield Bash";
		AbilityDescription = "The Aegis bashes an enemy while slightly raising his/her defense.";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
