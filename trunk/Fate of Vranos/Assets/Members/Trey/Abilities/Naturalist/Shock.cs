using UnityEngine;
using System.Collections;

public class Shock : BaseAbility {
	
	public void ShockAbility(){
		AbilityName = "Shock";
		AbilityDescription = "Summon an arc of electricity from the palm of your hand.";
		AbilityType = 1;
		AbilityTier = 1; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}


