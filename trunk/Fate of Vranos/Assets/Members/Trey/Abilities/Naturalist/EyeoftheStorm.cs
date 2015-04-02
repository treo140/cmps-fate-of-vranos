using UnityEngine;
using System.Collections;

public class EyeoftheStorm : BaseAbility {
	
	public void EyeoftheStormAbility(){
		AbilityName = "Eye of the Storm";
		AbilityDescription = "Become the center of the hurricane and increase your shock damage.";
		AbilityType = 0;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
