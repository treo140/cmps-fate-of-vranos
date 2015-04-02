using UnityEngine;
using System.Collections;

public class ThickSkin : BaseAbility {
	
	public void ThickSkinAbility(){
		AbilityName = "Thick Skin";
		AbilityDescription = "Tougher skin has granted increased health.";
		AbilityType = 0;
		AbilityTier = 3; 
		FocusCost = 10;
		SkillPointCost = 1;

	}
	
}
