using UnityEngine;
using System.Collections;

public class OilBomb : BaseAbility {
	
	public void OilBombAbility(){
		AbilityName = "OilBomb";
		AbilityDescription = "Covers an enemy in oil.";
		AbilityType = 1;
		AbilityTier = 2; 
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}

