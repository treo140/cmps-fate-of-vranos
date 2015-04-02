using UnityEngine;
using System.Collections;

public class FrostShield : BaseAbility {
	
	public void FrostShieldAbility(){
		AbilityName = "Frost Shield";
		AbilityDescription = "Through further understanding of the ice, the elementalist can absorb more damage and also freeze enemies that attack.";
		AbilityType = 0;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
