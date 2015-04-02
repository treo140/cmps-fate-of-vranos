using UnityEngine;
using System.Collections;

public class ChemicalY : BaseAbility {
	
	public void ChemicalYAbility(){
		AbilityName = "Chemical Y";
		AbilityDescription = "Chemical Y gives a random stat debuff to the enemy team.";
		AbilityType = 1;
		AbilityTier = 4;
		FocusCost = 10;
		SkillPointCost = 1;
	}
	
}
